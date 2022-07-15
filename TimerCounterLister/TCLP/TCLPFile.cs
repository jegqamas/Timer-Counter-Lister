// This file is part of Timer Counter Lister
// A program that list and manage timers.
// 
// Copyright © Alaa Ibrahim Hadid 2021 - 2022
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation; either version 3 of the License, 
// or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.See the GNU Lesser General Public 
// License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using ManagedUI;

namespace TimerCounterLister
{
    class TCLPFile
    {
        private const byte FORMAT_FILE_VERSION = 1;// Never edit this until the format is updated.
        /// <summary>
        /// Save project file
        /// </summary>
        /// <param name="filePath">The full path where to save the project</param>
        /// <param name="profile">The profile object to save</param>
        /// <param name="savingMethod">The saving method to use</param>
        /// <param name="useCompress">Indicates if the compression should be used or not.</param>
        /// <returns>True if the project saved successfully otherwise false.</returns>
        public static bool SaveProfileFile(string filePath, Profile profile, TCLPSavingMethod savingMethod, bool useCompress)
        {
            Stream main_stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            try
            {
                // First of all, save the main header
                List<byte> header = new List<byte>();

                // First 4 bytes are the ID
                header.AddRange(Encoding.ASCII.GetBytes("TCLP"));
                // Second: byte is the format file version.
                header.Add(FORMAT_FILE_VERSION);
                // Third: byte is the project file version.
                header.Add(Profile.VERSION);

                // Fourth: byte is parameters # 1.
                byte pp = 0;
                pp |= (byte)savingMethod;
                if (useCompress)
                    pp |= 0x10;
                header.Add(pp);

                // Fifth: byte is parameters # 2.
                pp = 0;
                // TODO: parameters # 2 in TCLP file.
                header.Add(pp);

                // Sixth: 4 bytes the data size, this will be added later.

                // Now the actual data
                byte[] projectData = new byte[0];
                SaveProfileData(ref profile, savingMethod, out projectData);

                // Compress ?
                if (useCompress)
                {
                    byte[] projectDataCompressed = new byte[0];
                    CompressData(ref projectData, out projectDataCompressed);

                    // Update the size
                    header.AddRange(BytesFromInt32(projectDataCompressed.Length));

                    // Now write the data
                    main_stream.Write(header.ToArray(), 0, header.Count);
                    main_stream.Write(projectDataCompressed, 0, projectDataCompressed.Length);
                }
                else
                {
                    // Update the size
                    header.AddRange(BytesFromInt32(projectData.Length));

                    main_stream.Write(header.ToArray(), 0, header.Count);
                    main_stream.Write(projectData, 0, projectData.Length);
                }
                main_stream.Flush();
                main_stream.Close();
                main_stream.Dispose();
            }
            catch (Exception ex)
            {
                main_stream.Flush();
                main_stream.Close();
                main_stream.Dispose();

                Utilities.ShowError(ex, Properties.Resources.Error_UnableToSaveProfile, Properties.Resources.Title_SaveProfile);

                return false;
            }

            return true;
        }
        /// <summary>
        /// Open project file
        /// </summary>
        /// <param name="filePath">The project file full path</param>
        /// <param name="profile">The project object that will be set. It will be set to null if open process fails.</param>
        /// <returns>True if the project opened successfully otherwise false.</returns>
        public static bool OpenProfileFile(string filePath, out Profile profile)
        {
            profile = null;
            Stream main_stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            try
            {
                if (main_stream.Length < 10)
                {
                    throw new Exception(Properties.Resources.Error_FileSizeIsLessThanExpected);
                }

                byte[] header = new byte[12];
                main_stream.Read(header, 0, 12);

                // 4 bytes: TCLP
                if (Encoding.ASCII.GetString(header, 0, 4) != "TCLP")
                {
                    throw new Exception(Properties.Resources.Error_FileIsNotTCLFile);
                }

                // 1 byte: file version
                byte ver = header[4];

                if (ver != FORMAT_FILE_VERSION)
                {
                    throw new Exception(Properties.Resources.Error_InomplatibleTCLFileVersion);
                }

                // 1 byte: project version
                byte pver = header[5];

                if (pver != Profile.VERSION)
                {
                    throw new Exception(Properties.Resources.Error_InomplatibleTCLProfileVersion);
                }
                // 1 byte: saving method
                //ASMPSavingMethod savingMethod = (ASMPSavingMethod)header[4];

                // 1 byte: parameters # 1
                byte parameters = header[6];

                TCLPSavingMethod savingMethod = (TCLPSavingMethod)(parameters & 0x0F);
                bool compressed = (parameters & 0x1) != 0;

                // 1 byte: parameters # 2
                parameters = header[7];

                // 4 bytes: file size
                int size = IntFromBytes(new byte[] { header[8], header[9], header[10], header[11] });

                // xx Byte: the project data
                byte[] projectData = new byte[size];
                main_stream.Read(projectData, 0, size);

                // Finish !! close the stream
                main_stream.Flush();
                main_stream.Close();
                main_stream.Dispose();

                // Read the saved project data
                if (compressed)
                {
                    byte[] uncompressedProjectData = new byte[0];
                    DecompressData(ref projectData, out uncompressedProjectData);

                    ReadProfileData(ref uncompressedProjectData, savingMethod, out profile);
                }
                else
                {
                    ReadProfileData(ref projectData, savingMethod, out profile);
                }
            }
            catch (Exception ex)
            {
                main_stream.Flush();
                main_stream.Close();
                main_stream.Dispose();

                Utilities.ShowError(ex, Properties.Resources.Error_UnableToOpenProfileFile, Properties.Resources.Title_OpenProfile);

                return false;
            }
            return true;
        }

        /*Save data using saving method. (YOU CAN ADD SAVING METHODS HERE)*/
        private static void SaveProfileData(ref Profile profile, TCLPSavingMethod savingMethod, out byte[] data)
        {
            data = new byte[0];

            switch (savingMethod)
            {
                case TCLPSavingMethod.None:
                    {
                        throw new System.Exception(Properties.Resources.Error_SavingMethodSetToNone);
                    }
                case TCLPSavingMethod.Serialize:
                    {
                        // Simply serialize project data...
                        MemoryStream mStr = new MemoryStream();
                        BinaryFormatter formatter = new BinaryFormatter();
                        // Now serialize !
                        formatter.Serialize(mStr, profile);
                        // Return the data
                        data = new byte[mStr.Length];
                        mStr.Seek(0, SeekOrigin.Begin);
                        mStr.Read(data, 0, (int)mStr.Length);

                        break;
                    }
            }
        }
        private static void ReadProfileData(ref byte[] data, TCLPSavingMethod savingMethod, out Profile profile)
        {
            profile = null;

            switch (savingMethod)
            {
                case TCLPSavingMethod.None:
                    {
                        throw new System.Exception(Properties.Resources.Error_SavingMethodSetToNone);
                    }
                case TCLPSavingMethod.Serialize:
                    {
                        // Simply serialize project data...
                        MemoryStream mStr = new MemoryStream(data);
                        BinaryFormatter formatter = new BinaryFormatter();
                        // Now de-serialize !
                        profile = (Profile)formatter.Deserialize(mStr);
                        break;
                    }
            }
        }
        /*Helper methods for compressing.*/
        public static void CompressData(ref byte[] inData, out byte[] outData)
        {
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(output, CompressionMode.Compress))
            {
                dstream.Write(inData, 0, inData.Length);
            }
            outData = output.ToArray();
        }
        public static void DecompressData(ref byte[] inData, out byte[] outData)
        {
            MemoryStream input = new MemoryStream(inData);
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
            {
                dstream.CopyTo(output);
            }
            outData = output.ToArray();
        }
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[2000];
            int len;
            while ((len = input.Read(buffer, 0, 2000)) > 0)
            {
                output.Write(buffer, 0, len);
            }
            output.Flush();
        }
        private static int IntFromBytes(byte[] data)
        {
            int val = 0;
            if (data.Length == 1)
                val = data[0];
            else if (data.Length == 2)
                val = (short)((data[0] << 0) | (data[1] << 8));
            else if (data.Length == 3)
            {
                val = (data[0] << 0) | (data[1] << 8) | (data[2] << 16);

                if ((val & 0x800000) != 0)
                    val |= ~0xffffff;
            }
            else if (data.Length == 4)
                val = (data[0] << 0) | (data[1] << 8) | (data[2] << 16) | (data[3] << 24);
            return val;
        }
        private static byte[] BytesFromInt16(short val)
        {
            byte[] data = new byte[2];
            data[0] = (byte)(val & 0xFF);
            data[1] = (byte)((val & 0xFF00) >> 8);
            return data;
        }
        private static byte[] BytesFromInt32(int val)
        {
            byte[] data = new byte[4];
            data[0] = (byte)(val & 0xFF);
            data[1] = (byte)((val & 0xFF00) >> 8);
            data[2] = (byte)((val & 0xFF0000) >> 16);
            data[3] = (byte)((val & 0xFF000000) >> 24);

            return data;
        }
    }
}

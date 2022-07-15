# Timer Counter Lister
A program that list and manage timers.


**Please note that this is the official repository of the program, that means official updates on source and releases will be commited/published here.**

### [DOWNLOAD LATEST RELEASE (VERSION)](https://github.com/jegqamas/Timer-Counter-Lister/releases)
### [GETTING STARTED ? CLICK HERE](https://github.com/jegqamas/Timer-Counter-Lister/wiki)

## Snapshots

![Snapshot 1](/snaps/snap1.PNG?raw=true "Snapshot 1")
![Snapshot 2](/snaps/snap2.PNG?raw=true "Snapshot 2")
![Snapshot 3](/snaps/snap3.PNG?raw=true "Snapshot 1")
![Snapshot 4](/snaps/snap4.PNG?raw=true "Snapshot 2")

## INSTALLATION
Simply extract the program release file into a drive in pc. Use "TimerCounterLister.exe" to run the program.

## IMPORTANT!
Please make sure your pc meet these requirements to ensure the program work correctly:
- Works with Microsoft Windows® XP / Vista / 7 / 8 / 8.1 and 10.
- Processor: 1700 Mhz or higher (Intel or AMD). 
- Memory: 512 MB RAM or higher 
- Microsoft .Net Framework 4.8
- Drivers: DirectX 9 or higher 

## Notes
- This program is built using ManagedUi, An advanced managed enviroment for C# desktop applications. Please see <https://github.com/jegqamas/Managed-UI> for more details.
- This program uses ClosedXML, ClosedXML is a .NET library for reading, manipulating and writing Excel 2007+ (.xlsx, .xlsm) files. It aims to provide an intuitive and user-friendly interface to dealing with the underlying OpenXML API. <https://github.com/ClosedXML/ClosedXML>

## INTRODUCTION
Timer Counter Lister is a program that allows to add timers and manage them easily. It meant to be as simple as possible and user-friendly.

Simply user can start new profile which include timers and related data. Then user can start adding timer(s) one by one and start them...

Each timer store the time passed and clocks in rate that can be configured (regaldess of configuration, built-in hi-res timer based on cpu clock is used fo clocking), also, another information is stored with each timer and can be used such as calculating a cost per minute, also store balance to set that cost.

Timer Counter Lister can be used in many ways in life, examples:
- It can be used to count a work of person occurding to time and calculate the cost accuretly.
- It can be used to rent pcs in places where pcs are rent for differenc reasons such as gaming, internet ...etc 
- It can be used to count and calculate the cost of delivery services such as posts, trucks...etc
- Also it can be used to see how much time a person is spending on something like gaming for example, since any timer can be set with Alarms.

And more....

## FEATURES
- Can store huge numers of counters in small-size profile which can be saved in machine.
- A profile can be protected with password, also, it can be protected so that the program asks for password each time an activity detected.
- Uses Hi-Res timer which clocks using pc cpu, user can control timer clock rate to control performance of the program but not the accuracy of the counter.
- Include the ablilty to resume a timer and calculate the timer has passed since last pause, this might help in situation when profile is closed, program crash ..etc
- Include Alarm system, which means alarms can be added to each timer to notify user when they trigger after a period of time set by the alarm. Also alarm can play sound of user choice.
- Include Transaction system which allows to clear cost with pay and store currency in Balance. 
- Store activities for every timer that cannot be edited or deleted, also these events can be exported into files.
- Built using ManagedUI <https://github.com/jegqamas/Managed-UI> which present a very beautiful managed gui (graghical user interface), user can change layout, theme, menu items....etc
- Multilangual support.

## NOTES:
- USER AT YOUR OWN RISK: if this program is used for business porpuses, or any other porpuses, please make sure that the program suit that porpuse. 

It is recommended to do proper tests of suitibilty of this program to that porpuse before using this program.

This program is licensed under GNU General Public License 3, that's mean, developer take no responsability of any kind of result from using this program.

Please see <http://www.gnu.org/licenses/> for more information. 
- Accuracy of alarms and cost calculating is depends on the timer interval (clock rate) which can be set when adding the timer.
- Performance of the program depends on how many timers are clocking and the clock rate of these timers at a time, also it can mean that the only limitation of how many timers can be added into one profile and used is the size of profile file and the power of the pc cpu.
- The program may run with scalling problems (like 4K monitors), this is normal hence the program is designed to run in full HD monitors. you may want to try changing the DPI settings, simply right-mouse-click on the program main executable file, then in Compatibilty page, click Change high DPI Settings.

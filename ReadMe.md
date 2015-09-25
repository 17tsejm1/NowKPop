Messenger For Windows Store
============================

The MessengerForWindows project is a Windows Store app that I built simply to get Facebook's new Messenger.com service (released yesterday) into a dockable app window that Windows users can play with. I built it in a little over 3 minutes (so fast because there isn't a whole lot of code here) primarily so others can see how easy it is to build apps. Take a look at the video if you have ~3 minutes or so. This is by no means production quality and certainly not an official Facebook app.

If you have any questions, feel free to ping me at elmer.morales@gmail.com or on Twitter at @elmerm. Enjoy!

##How To Install the App

Since this app isn't in the Windows Store, you'll need to use a method known as sideloading to run it on your Windows 8.1 PC. Please follow the steps below. 

1. From your Windows PC, navigate to the 'AppPackages/MessengerForWindows_1.0.0.1_AnyCPU_Test' directory. If you are running Windows RT, then you will need to use the package found in the directory 'AppPackages/MessengerForWindows_1.0.0.1_ARM_Test'.
2. Find the file 'Add-AppDevPackage.ps1' and right click.
3. Select the "Run with Powershell" command from the right-click menu.
4. Follow the on-screen instructions.
5. Once complete, the app should be available from your Start screen under the name "Messenger".

Microsoft has an article on sideloading apps which is much more extensive than these instructions. Check it out if you get stuck. https://technet.microsoft.com/en-us/windows/jj874388.aspx.

##Updates
UPDATED 04/15/2015: Added an app bar that is shown when the app initially launches and allows you to navigate to the login screen. This addresses the issue some people experienced with not being able to sign in. Also includes a second AppPackage targeted at WindowsRT devices.

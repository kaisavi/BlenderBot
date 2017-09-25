# BlenderBot
Blenderbot is a utility that I made to run along-side Blender. When configured correctly you can use it to start a render, and be notified when it has finished


  # Usage
  ## Install
  If you would like to use this application, you must [download](https://www.dropbox.com/s/wp37lxy8sqwi4p1/Blenderbot2-Setup.msi?dl=1) and run the installer.

   ## Setup
   
   ### Application
 When you start the application, the first thing you will need to do is configure it in the **Preferences** dialog.
 
 Control | Usage
 --- | --- 
 Blender Executable | Directory of Blender.exe **(Required)**
 Projects Folder | Directory of your .blend files **(Recommended)**
 Channel ID | The ID of the channel that you want to recieve the message in **(Required for notifications - default will send notification to an empty channel - See below for instructions on Discord setup)**
 Render Format | Format of the output image. Default is reccomended.
 Animation Format | Format of output animation.
 Save User Settings | Applies the changes to your configuration file **(Closing the dialog before saving will discard changes)**
 
 Click the file icons to browse.
 
 ----
 
 ### Discord
 1. [Add Blenderbot to your Discord server and allow it to send messages](https://discordapp.com/oauth2/authorize?&client_id=323891647739985920&scope=bot&permissions=0)
 2. Configure the application with a channel ID
 <details>
 <summary>Walkthrough with images</summary>
 Copy the channel ID <br />
 <img src="https://i.imgur.com/UdwvjuZ.png" /> <br />
 Paste into the Channel ID box in the Preferences dialog <br />
 <img src="https://i.imgur.com/hyeu3Yp.png" />
 </details>
 
 ----
 ## Render
 
 Control | Usage
 ---- | ----
 File | Enter the name of your .blend file (don't include the extension) or click the icon to browse your projects folder.
 Frame | The frame which you would like to render. Slide, use the arrows, or enter a custom value.
 Shutdown | if this is checked, your computer will shutdown after the render has finished (you will still be notified).
 
 ---
 
 # Notes
 * Animations are not yet supported.
 * Planned feature: Render image sent through Discord with notification.
 * Considering email, Skype, and possibly SMS notifications.

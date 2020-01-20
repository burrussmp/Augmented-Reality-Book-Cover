# Augmented-Reality-Book-Cover
A Unity Project to augment the book "Hacking Whiskey" by Aaron Goldfarb

# Description of the Code

The "Hacking Whiskey" Augmented Book cover was made in Unity editor for Ubuntu using the latest Vuforia engine (7.*) for augmented reality and advanced computer vision tasks. Tested on Google Pixel 2 (Android)  


# Getting Started

1. ```git clone https://github.com/burrussmp/Augmented-Reality-Book-Cover.git```

2. Open up ```UnityHub``` and add the cloned project.

3. In ```/Assets/Scenes/``` open ```SampleScene```. Select the ```FrontCoverTarget``` and double check that a target image is available (Image Target Behaviour/ where Type should be From Database, Database should be AugmentedBookCover, and Image Target should be Front_Cover_Hacking_Whiskey). Do the same for the ```BackCoverTarget``` and make sure the Image Target is Back_Cover_Hacking_Whiskey.

4. In ```Build Settings``` change Platform to ```Android``` and click ```Switch Platform```

5. From editor, navigate to ```Edit/External Tools``` and ensure SDK is pointed to correct path where android studio is installed. For me, this is ```/home/username/Android/Sdk```. 

6. Note: I had to run ```android update``` for the build to be successful

7. Connect the device

8. In a terminal, run ```adb start-server & adb devices``` to ensure device is connected

9. In ```Build Settings``` in ```Scenes in Build``` and check scene ```Scenes/SampleScene```

10. In ```Run Device``` select the plugged in phone (Note: If device not appearing, make sure you are in Developer mode)

11. ```Build and Run``` and save for example `ARBookCover.apk`

12. Point at images below!

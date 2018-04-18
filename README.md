# VRClass

A VR (Virtual Reality) application for education. Built in Unity for an Android phone equipt with a Google Daydream, the application sets the user into a 360 environment where they can interact with Points of Interest (or POIs)

This document will explain the scripts used and the file heiarchy. 

## File Heiarchy

This section will explain where the important tools for the application lie and what you can find everywhere in the app.

### Asset

This is where all the folders exist. This is the root folder which all other folders exist.

### Asset/Editor

This folder holds the editor scripts used to help the developer. Currently there is one script. This script is called NewBehaviourScript and is used to create inverted spheres of variable sizes. This is how the 360 image viewer is created.

### Asset/GoogleVR

This folder contains all the VR folders/files used in order to develop and build for the Google Daydream

### Asset/GoogleVR/VRClass

This folder contains unique items for the application. In this folder, you will start off with 4 360 images, all of which are compatible with the 360 viewer. You may also find a renderTexture for video viewing, VideoRender. VideoRender will be explained in the VideoViewer Scene. Finally, you have 2 folders. 

### Asset/GoogleVR/VRClass/Material

This folder contains the 3 materials for the 360 image. 

### Asset/GoogleVR/VRClass/Scene

In this folder, there are 3 scenes. Each scene also has a folder with it's name. That folder contains the lighting data for the specific scene. If you change the lighting, or create a new scene, you will need to change the lighting from default.

### Asset/Resources

In this folder, you will find various images, videos, as well as a folder called Material. The items here are used througout the app and are explained in the scripts section. DO NOT RENAME THIS FOLDER UNLESS YOU WORK AROUND SENDING DATA FROM ONE SCENE TO ANOTHER.

### Asset/Scripts

In this folder, you have all the scripts. Each script is described below in the scripts section.

### Asset/Streaming

In this folder, there is data if you decide to use the GoogleVR API for video streaming. I have not been using it. 

## Scripts

This section gives the information about each script, going into as much detail as possible.

### BackButton

This script is given to an object and once clicked, will take the user back to the scene Lake.

### PlayerClass

This script is the bread and butter of the file loading. How the script works is it can be accessed globablly and holds the data on the image or video. Since it can be accessed globablly, we first set the data with the file in the Lake scene then take it to either the VideoViewer or the FileViewer scene.

### FileHandler

This script is given to an object in the FileViewer scene which will be used to view an image. It loads the texture from Asset/Resources by getting the data from PlayerClass and giving it to the parent object.

### MoreInfoButton

This script is used for an imbeded POI, given to an object which should only be active if the parent is selected. The idea is that if the other text which the POI is parent to is clear, then it won't be able to be selected. Otherwise, you can click on it and send data to the destination scene. The destination is manually typed in to determine if it is going to FileViewer or VideoViewer. The "URL" (file name) determines which piece of data is given to the PlayerClass.

###  Show_OnClick

This script is used for a POI which contains another POI as well as text. On Click, it transforms the color of the text to either white or clear. On hover, it changes colors, only to return to transparent after the cursor leaves.

### Show_OnClickVideo

This script was initially used for just video POIs, but was later changed to be used by any POI that takes the user to either FileViewer or VideoViewer. It is very similar to MoreInfoButton, only it has less to worry about since these POIs are independent. When hovered, it changes colors, only to change back to transparent once the cursor leaves. When clicked, it gives the data on what file is needed to PlayerClass then loads the destination.

### Toggle_Script

This script is used for an object which will be used to toggle on or off all the POIs. It has a dynamic List which you will add all the POIs to and then makes them all one color to help identify where they are.

### VideoHandler

This is the script used for video playing. It starts off by applying the video to the object, then gives it the ability to play and pause by clicking the object.

## Scenes

This section will describe what each scene is for.

### Lake

I like to image this scene as the Main scene. This is where all the POIs will lie. If this was an adventure video game, this is your map. 

### FileViewer

This is where you have your images be viewed. How this area works is before the scene starts, the POI gives PlayerClass the file you want to view. Then, once the scene starts, it uses Resource.Load() to load in the file as a texture and apply that to an Object in the scene. You can then leave the scene using the back button

### VideoViewer

It's really similar to FileViewer in how it works, with the only difference being it has to do a few extra steps with this being a VideoClip rather than a texture.
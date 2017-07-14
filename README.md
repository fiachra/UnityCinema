# Surround Cinema Test

This is a Unity project designed to test some of the options available for surround audio in Unity.  

## Getting Started

Clone this Repo and open the project in Unity. Open the Scene Cinema.unity to see the system

### Prerequisites

This Project was created in Unity 5.5 and requires a **Unity Pro Licence**. 
This Project has only been testing on OSX so far.

### System Operation

To create the cinema a video with a 5.1 audio track was acquired online. Next, that videos audio tracks were opened and exported separately as WAVs using Audacity. 

The [Cinema Model blend file](https://free3d.com/3d-model/cine-room-62699.html) was opened in blender, exported to FBX and imported into Unity. 

A plane was added to the scene to act as the screen and the video (with no embedded audio) was added as a movie texture. 

6 Audio sources were added to the scene, positioned in a 5.1 configuration and set to 3D sources.

The VideoSurroundManager class was created just to have a central place to connect audio clips to audio sources and to manage the looping.  


## Author

* **Fiachra Matthews** [Github Page](https://github.com/fiachra)

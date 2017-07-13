# Surround Cinema Test

This is a Unity project designed to look at some of the options available for surround audio in Unity.  

## Getting Started

Clone this Repo and open the project in Unity. Open the Scene Cinema.unity to see the system

### Prerequisites

This Project was created in Unity 5.5 and requires a * **Unity Pro Licence**. 

### System Operation

To create the cinema a video with a 5.1 audio track was acquired online. Next, That Videos audio trackes were opened and exported seperatly as WAVs using Audacity. 

The [Cinema Model](https://free3d.com/3d-model/cine-room-62699.html) opened in blender, exported to FBX and Imported into Unity. 

A Plane was added to the scene to act as the screen and the video (with no embeded audio) was added as a movie texture. 

6 Audio sources were added to the scene and positioned in a 5.1 configuration.

The VideoSurroundManager class was created just to have a central place to connect audio clips to audio sources and to manage the looping.  


## Author

* **Fiachra Matthews** [Github Page](https://github.com/fiachra)

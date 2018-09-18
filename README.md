# A Maze
Starter project for the Udacity [VR Developer Nanodegree](http://udacity.com/vr) program.

- Course: VR Software Development
- Project: A Maze


### Versions Used
- [Unity LTS Release 2017.4.4](https://unity3d.com/unity/qa/lts-releases?version=2017.4)
- [GVR SDK for Unity v1.100.1](https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.100.1)


### About the Starter Project
The included starter project represents a new Unity project where the following have been done:
- All assets needed to complete the project according to the project rubric have been imported.
- The imported models have been placed in the scene and organized in the scene hierarchy.
- Colliders have been added to the `Coin`, `Key`, `Left_Door`, `Right_Door`, and `The_Temple` game objects, and to the `Maze` game object's child game objects.


### Related Repositories
- [VR Software Development - Creating Scripts](https://github.com/udacity/VR-Software-Development_Creating-Scripts/releases)
- [VR Software Development - Controlling Objects Using Code](https://github.com/udacity/VR-Software-Development_Controlling-Objects-Using-Code/releases)
- [VR Software Development - VR Interaction](https://github.com/udacity/VR-Software-Development_VR-Interaction/releases)
- [VR Software Development - Programming Animations](https://github.com/udacity/VR-Software-Development_Programming-Animations/releases)
- [VR Software Development - Physics and Audio](https://github.com/udacity/VR-Software-Development_Physics-and-Audio/releases)
- [VR Software Development - Advanced VR Scripting](https://github.com/udacity/VR-Software-Development_Advanced-VR-Scripting/releases)
- VR Software Development - A Maze

### Personal additional considerations
This scene got bigger than the previous project. The previous project could only have between 15 and 50 objects on the same scene but this one have much more than that, this concerns me about performance issues. Even though it ran fine on my mobile (Moto Z3 play), it took 40 minutes to 1 hour to bake the lighting on resolution set to 30(the previous one took about 5 minutes on 80 resolution). I also had problems to light the flag with baked lighting, even unlit shader didn't work.

Also the models aren't much simetric, the walls all have the same size so you can kinda have a "grid" on it, but the pillar plus its fittings breaks this grid by adding a non fixed size, so I had to put more walls or re-scale some of them, so I have some clipping.

I'd like tips on how should I use those models to avoit this to happen, the overload of models making the bake take too long, and asymmetric models to avoid clipping.
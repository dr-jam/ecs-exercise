
# Assignment 4 #

## Primer for Assignment 4##

In order to do this assignment, become familiar with the stats tab within the Unity GUI.

The stats tab will be on the Game view tab. Enable this in order to see the FPS to do this assignment.

For more information: https://docs.unity3d.com/Manual/RenderingStatistics.html

You will also need to install some packages. Here is how to do it.

https://github.com/Unity-Technologies/EntityComponentSystemSamples#installation-guide-for-blank-ecs-project

There are three different GameManager scripts and one GameManager object. 

For Stage 1 use ClassicGameManager.

For Stage 2 use JobGameManager.

For Stage 3 use ECSGameManager.

## Definitions ##

FPS stands for Frames Per Second.

ECS stands for Entity Component System


## Stage 1: Classic ##

Using the framerate counter and the Debug.Log, write down how many game objects are created until your machine hits 30 fps.

To create game objects, hit the space bar and it will generate more game objects.

For a point of reference, on my machine (AMD RX 570 and i7-2600k), I was able to get about 14500 around 30fps

You do not need to write any code for this part, just finding out the number of game objects.	

Number of Game Objects : #PUT NUMBER HERE#

## Stage 2: Jobs ##

Using the job system within Unity, abstract out the transform data to be complaint to the job system.

Generate the game objects again and see how many can be on screen at 30 fps.

For a point of reference, on my machine (AMD RX 570 and i7-2600k), I was able to get about 21000 around 30fps

Some resources: 

https://docs.unity3d.com/Manual/JobSystem.html

https://www.youtube.com/watch?v=WZ6-LxwxWEI

Number of Game Objects : #PUT NUMBER HERE#

## Stage 3: ECS ##

Using the Entity Component System, attempt to increase performance by using the Entity Component System job system.

Generate the game objects again and see how many can be on screen at 30 fps.

For a point of reference, on my machine (AMD RX 570 and i7-2600k), I was able to get about 80000 around 30fps.


This will be a bit more difficult as it will require a different mindset when programming.

It is recommend to watch the official Unity tutorial series. (Part 3 is in the resources for stage 2).

https://www.youtube.com/watch?v=WLfhUKp2gag

However do not use the code in the official tutorial as it is obselete. 

In order to properly move the position of the entity, use Translation which is apart of Unity.Transform.


Resources: 

https://github.com/Unity-Technologies/EntityComponentSystemSamples

https://docs.unity3d.com/Packages/com.unity.entities@0.0/api/Unity.Transforms.html

https://wiki.unity3d.com/index.php/Entity_Component_System#Documentation

This will be highly dependent on how well you write your code. It is fine if performance decreases.

Number of Game Objects : #PUT NUMBER HERE#
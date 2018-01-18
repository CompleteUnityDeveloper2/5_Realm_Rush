# Complete Unity Developer 2.0 - Section 5 - Realm Rush

This is the long-awaited sequel to the Complete Unity Developer - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects and our latest teaching techniques. You will benefit from the fact we have already taught over 300,000 students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo.

## In This Section
This is a 3D isometric tech demo designed to teach the fundamentals of AI pathfinding, namely Breadth First Search or BFS. (Section REF: RR_CU2)

## How To Build / Compile
This is a Unity project. If you're familiar with source control, then "clone this repo". Otherwise download the contents, and navigate to `Assets > Levels` then open any `.unity` file.

This branch is the course branch, each commit corresponds to a lecture in the course. The current state is our latest progress.

## Lecture List
Here are the lectures of the course for this section...

### 1 Welcome To Section 5 ###

**In this video (objectives)…**

1. How this project fits into the course.
2. A peek at what we'll be building.
3. Why not use Unity's built-in pathfinding.
4. You'll learn C# co-routines, `Queue`, `Dictionary`.
5. Order independent execution, editor scripts and more in Unity.

**After watching (learning outcomes)…**

Explain to a fellow student roughly what we're building, and why this is awesome stuff to know.

### 2 Limitations Of Unity Pathfinding ###

**In this video (objectives)…**

1. A quick overview of Unity's NavMesh.
2. How our system compares.


**After watching (learning outcomes)…**

Explain why we are creating pathfinding from scratch.


### 3 Z-Fighting And Quads ###

**In this video (objectives)…**

1. Demonstrate z-fighting problem.
2. Show quads as building blocks.
3. Demonstrate back face culling.
4. Create labelled block prefab.

**After watching (learning outcomes)…**

Build simple objects from cubes, and describe both back face culling, and z-fighting.


### 4 ExecuteInEditMode Attribute ###

**In this video (objectives)…**

1. Why we want snapping in our world.
2. How to use Unity's snap feature.
3. The limitations and why we write our own.
4. Introducing `[ExecuteInEditMode]` attribute.
5. Introducing `[Range()]` attribute.


**After watching (learning outcomes)…**

Enforce snapping in the Unity editor using an "editor script".


### 5 Using Text Mesh For Labels ###

**In this video (objectives)…**

1. How to use Text Mesh in Unity
2. Text Mesh vs UI Text
3. Using the `[SelectionBase]` attribute
4. Using 'GetComponentInChildren()'


**After watching (learning outcomes)…**

Use Text Mesh to label objects in the world for debug.

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


### 6 C-Sharp Lists For Custom Path ###

**In this video (objectives)…**

1. The `List<>` syntax
2. Lists vs arrays
3. Creating a custom waypoint path.


**After watching (learning outcomes)…**

Use a simple list in C#.


### 7 Introducing Coroutines ###

**In this video (objectives)…**

1. How loops stall of block our code
2. Use 'IEnumerator' as a return type
3. Using 'StartCoroutine()'
4. How to 'yield' execution
5. Returning a yield instruction
6. Using 'WaitForSeconds()'


**After watching (learning outcomes)…**

Use a basic co-routing to make a time-based sequence appear to run in parallel to the rest of your game code.


### 8 Types Of Pathfinding ###

**In this video (objectives)…**

1. Look at Breadth First Search (BFS)
2. Compared to Dijkstra's algorithm and A*
3. Why A-Star isn't always the best best


**After watching (learning outcomes)…**

Discuss the basic differences between three pathfinding algorithms.


### 8b The Path Ahead ###

Ben explains what to expect in the next two videos.


### 9 Instance Variables And Constants ###

**In this video (objectives)…**

1. Used `const` for `gridSize` global data
2. Discussed dependencies
3. Refactored our code.

**After watching (learning outcomes)…**

Move information from one class to another, and use `const` where appropriate.


### 10 The Dictionary Data Structure ###

**In this video (objectives)…**

1. Setup our first C# dictionary for our grid
2. Syntax: `Dictionary<Vector2Int, Waypoint> grid`
3. Use `grid.Add()` to add elements
4. Use `grid.ContainsKey(gridPos))` to detect duplicates.


**After watching (learning outcomes)…**

Recognise (but not necessarily use), basic C# dictionaries.

**In this video (objectives)…**


### 11 Finding Game Objects By Name ###

1. Discuss how to find a child object from a script
2. Use `transform.Find()` to find by name
3. Color our blocks with `waypoint.SetTopColor()`


**After watching (learning outcomes)…**

Find other game objects by their name.


### 12 Explore Thy Neighbour ###

**In this video (objectives)…**

2. See how `+` can join strings, and add vectors.
3. Use `try {} catch {}` to catch errors.


**After watching (learning outcomes)…**

Specify a list of allowable directions and "explore" in them.


### 13 Breadth First Search Algorithm ###

**In this video (objectives)…**

1. Look at the Wikipedia article on BFS
2. Demonstrate simpler pseudocode for BFS
3. Walk through BFS step-by-step.


**After watching (learning outcomes)…**

Manually perform Breadth First Search, and find the shortest path.


### 14 Introducing C# Queues ###

**In this video (objectives)…**

1. Define FIFO vs LIFO queues
2. Using `Queue<Type> queue` syntax
3. Using `Queue.Enqueue()`
4. Using `Queue.Dequeue()`
5. Detecting when end waypoint is found.


**After watching (learning outcomes)…**

Add and remove items from a C# queue.


### 15 Running Manual Tests ###

**In this video (objectives)…**

1. Use our `isRunning` state
2. Log out what we're queueing
3. Check pathfinding across whole grid.


**After watching (learning outcomes)…**

Use systematic manual testing to help write software.


### 16 A Breadcrumb Trail ###

**In this video (objectives)…**

1. Thanks to Eddie for spotting an improvement
2. Using `queue.Contains(neighbour)` to prevent duplicates
3. Improving our color architecture
4. Justifying the use of `public` vs `[SerializeField]`
5. Leave a breadcrumb.


**After watching (learning outcomes)…**

Explain why you would sometimes use `public`


### 17 Reversing A List ###

**In this video (objectives)…**

1. Create our list
2. Adjust our architecture
3. Hand over to Rick


**After watching (learning outcomes)…**

Manipulate C# lists, and create getter methods.


### 18 Adding Production Assets ###

**In this video (objectives)…**

1. Import art assets
2. Reconstruct our pathfinding block with the new look
3. Update the rest of our scene with a new look


**After watching (learning outcomes)…**

Import, implement and tune art assets for your scene.


### 19 Tower LookAt Enemy ###

**In this video (objectives)…**

1. Construct a tower with base and top parts.
2. Use LookAt to move the top of the tower to look at a moving enemy.


**After watching (learning outcomes)…**

Use LookAt statement to control the rotation of a tower.


### 20 MagicaVoxel Bonus Content ###

**In this video (objectives)…**

1. Where to find additional content for creating MagicaVoxel assets.
2. What content we will cover in our MagicaVoxel community course.


**After watching (learning outcomes)…**

Aware of the MagicaVoxel Bonus Content.


### 21 Another Solo Challenge ###

**In this video (objectives)…**

1. Understand our remaining feature set for Realm Rush.
2. Overview of the process for shooting and damaging enemies.


**After watching (learning outcomes)…**

Ready to take on another big solo challenge.


### 22 Make Tower Shoot ###

**In this video (objectives)…**

1. Attach a bullet particle effect to the towers.
2. Create EnemyDamage script that recognises bullet collision.
3. Organise enemy's hierarchical structure to properly recognise collision.


**After watching (learning outcomes)…**

Create tower bullets which successfully collide with enemy.


### 23 Enemy HitPoints ###

**In this video (objectives)…**

1. Decrease enemy hitpoints when enemy is hit.
2. Destroy enemy when hitpoints are below 1.


**After watching (learning outcomes)…**

Implement enemy hitpoint and kill enemies.


### 24 Check For Distance ###

**In this video (objectives)…**

1. Create a condition where towers only shoot if enemy is within range.
2. Implement Vector3.Distance to determine distance from towers to enemies.
3. Turn on and off particle emission system if there is no valid enemy.


**After watching (learning outcomes)…**

Create a condition where towers only shoot if enemies are close enough.


### 25 Subtleties Of Spawning ###

**In this video (objectives)…**

1. Instantiate an enemy Manually
2. Resolve the root cause of the errors
3. Modify 'Pathfinder.cs' to "cache" path
4. Drone one about caching and naming again.


**After watching (learning outcomes)…**

Resolve issues with instantiating at runtime by practicing in Unity's Play mode.


### 26 Revise Coroutines & Much More ###

**In this video (objectives)…**

1. Show how to search our GitHub pages
2. Explain spawning architecture
3. Setup a spawning coroutine.


**After watching (learning outcomes)…**

Create a simple co-routine from scratch on your own. Remember "Blooms Taxonomy"


### 27 Target Closest Enemy ###

**In this video (objectives)…**

1. Revise instantiating
2. Challenge you to add audio to the game now
3. Modify `Tower.cs` to find closest enemy
4. Challenge you to write `Transform GetClosest(Transform b, Transform b)`


**After watching (learning outcomes)…**

Find the closest of two transforms.

### 28 Detecting Mouse In 3D ###

**In this video (objectives)…**

1. Introduce Unity's `OnMouseOver()` message
2. Show you how to troubleshoot message issues
3. Log out which block our mouse is over.


**After watching (learning outcomes)…**

Use Unity's built-in messages, and troubleshoot them from docs when not working.


### 29 Conditional Instantiation ###

**In this video (objectives)…**

1. Recap our design decisions for `Waypoint.cs`
2. Add the ability to flag a block as "placeable"
3. Use version control to find a bug we introduced
4. Differentiate between valid and invalid tower clicks.


**After watching (learning outcomes)…**

How to filter click input based on data about what's being clicked-on.


### 30 Bloom’s Taxonomy ###
**In this video (objectives)…**

1. Explain the basics of Bloom's Taxonomy again
2. Challenge to complete the tower placement.


**After watching (learning outcomes)…**

Combine your knowledge of `[SerializeField]` and `Instantiate()` in one exercise.


### 31 Particles & Algorithm Improvements ###

**In this video (objectives)…**

1. Fix a minor bug in our pathfinding algorithm
2. Add cool jet booster particles to our enemy
3. Add hit and death particle effects.


**After watching (learning outcomes)…**

Use particles effects two different ways, either referring to a prefab on the same game object, or a separate asset.


### 32 Circular Or Ring Buffers ###

**In this video (objectives)…**

1. Note we've changed to Unity 2017.3.**1**
2. Introduce a new mnemonic `www.wow`
3. Overview ring or circular buffers
4. Briefly discuss performance and memory fragmentation.


**After watching (learning outcomes)…**

Explain in simple terms what a ring buffer is.

### 33 Implementing A Ring Buffer ###

**In this video (objectives)…**

1. Create a Tower Factory class
2. Move the tower prefab, and max towers there
3. Introduce `this` in C#
4. Wire-up our tower factory, at least in outline.


**After watching (learning outcomes)…**

Use the `this` keyword to pass instances around.


### 34 Revising C# Queues ###

**In this video (objectives)…**

1. Discuss using a C# queue for a ring buffer
2. Practice pseudo coding
3. Get the queue managing its self.


**After watching (learning outcomes)…**

Implement simple C# queues from scratch.


### 35 How To Destroy Particles ###

**In this video (objectives)…**

1. Finish our ring buffer
2. Discuss how to destroy particle systems
3. Use Unity's `Destory(object, delay)` function


**After watching (learning outcomes)…**

Destroy instantiated particle effects when they have finished playing.


### 36 Complete Game Loop ###

**In this video (objectives)…**

1. Speed up enemy movement
2. Destroy enemies when they reach the end of their path
3. Trigger enemy goal particles


**After watching (learning outcomes)…**

Explode enemies after they have completed their path.


### 37 Health For Base ###

**In this video (objectives)…**

1. Increase the size of our level
2. Create a mechanism to decrease player health when enemy reaches base


**After watching (learning outcomes)…**

Create a simple collision-based health system for the player's base.


### 38 Display Health & Score ###

**In this video (objectives)…**

1. Add text fields to canvas UI for player health and score
2. Connect the player health code to the UI text
3. Increase score whenever new enemy is spawned
4. Connect score value to score text


**After watching (learning outcomes)…**

Create updating UI text elements for the gameplay values of score and health.


### 39 Unity Post Processing Stack ###

**In this video (objectives)…**

1. Import the Unity Post Processing Stack
2. Set up profile asset
3. Modify post processing aspects such as bloom, vignette and color grading


**After watching (learning outcomes)…**

Implement Unity Post Processing Stack to create a unique look for your game.


### 40 Hook Up SFX ###

**In this video (objectives)…**

1. Asset our sound design needs
2. Trigger SFX for spawning, base damage and enemy damage
3. Add music to the game


**After watching (learning outcomes)…**

Implement sound effects for key moments in the game.


### 41 PlayClipAtPoint() For SFX ###

**In this video (objectives)…**

1. Implement the PlayClipAtPoint() method to ensure our audio clip is played even if our GameObject is destroyed.
2. Investigate Unity's audio setup to discovery why our audio clip is played at lower volume.
3. Discuss 2D versus 3D spatial sounds in Unity.
4. Implement audio track.


**After watching (learning outcomes)…**

Create sound effects that persist even if the parent GameObject is destroyed.


### 42 Tune Your Game Moment ###

**In this video (objectives)…**

1. Looking at all the design levers available.
2. Understanding your intention, and how you can execute on that.
3. Finding the fun for a 2 minute game moment.
4. Share!


**After watching (learning outcomes)…**

Understand what levers to pull in order to make your game moment compelling.
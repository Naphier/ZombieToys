Complaints
- Ch 2 assesment wouldn't allow click on any element in the image.
- Repeating Ch2 assesment says I only got 50% right, which is completely incorrect
- Can't full screen videos
- Inconsistent video volume
- Sign in with Unity ID credentials doesn't work
- Login flow is terrible (need to go to Unity3d.com, login, then click the link provided in email)
- Next video button or autoplay next video feature is missing
- Does not save my place, seems to have stopped doing this at chapter 7. 
- Shows that I've completed the course, but I haven't.



=========================================================================================================================
Ch 1 - Game Dev Intro

At a game studio, this person is responsible for ensuring the overall look and feel is consistent:
- Game Designer
- Level Designer
- √ Art director
- Concept Artist


=========================================================================================================================
Ch 2 - The Unity User Interface

To reconfigure the Unity Editor user interface:
- Control + Click on the tabs and choose reposition
- Open the windowprefs.cs script and enter positions
- Choose Window > Window Locations from the menu
- √ Drag windows by their tabs into new locations

The Project Window allows you to:
- Change the maximum size of textures
- Parent objects in a hierarchy
- √ Modify the file structure of assets
- Add components to GameObjects

Which window allows parenting of GameObjects?
- √ Hierarchy
- Outliner
- Project
- Inspector

Which window in the Unity Editor allows you to view, sort, and organize all of the assets for the game?
- √ Project window
- Inspector window
- Scene view window
- Hierarchy window

Point out the UI control that makes sizes the icons in the Project window.


=========================================================================================================================
Ch 3 - Using GameObjects and Assets

Which of the following statements best differentiates a quad from a plane?
- √ The plane has internal divisions and more polygons
- Quads can be sculpted using terrain tools
- The plane has less geometry
- The quad is double-sided

Which tool allows you to manually slice an image into multiple sprites?
- The UI canvas
- The 2D prefab editor
- The bitmap tools 
- √ The sprite editor

Unity can import this transfer file format for models having meshes, bones, skin weights, and animations:
- DXF
- OBJ
- √ FBX
- HCQ

Saving a scene saves:
- Object transforms, project settings, and undo history
- All assocuated scenes and asset bundles in a project
- The inspector settings, scripts, assets and nested Prefab structure
- √ The current placement of objects in the scene and Hierarchy

A prefab in the Unity Editor is:
- A file formate that allows transfer of assets between Unity projects and scenes
- √ An asset type that stores a GameObject with components and properties
- A modular component attached to a GameObject for scripting and animation
- A special kind of GameObject that accesses Animators without scripting


=========================================================================================================================
Ch 4 - Managing Projects and Assets

Acceptible formats for audio are: 
- √ AIFF, MP#, WAV, and OGG
- MP3, Quicktime, and Egg
- MIDI, RCA, IFF, and MP3
- WAV, MP4, Ogg, and AVI

**The project window toolbar allows searching of assets by:**
- Type and tag
- Label and color
- Tag and parent
- √ Label and type

The two script types supported in Unity are:
- Lua and UnityScript
- UnityScript and Python
- √ C# and UnityScript
- UnitySharp and C++

The breadcrumb trail in the Project window shows:
- The structure of the open project
- The local repository clone
- The file path of the Unity Project
- √ The file path of the selected asset

Modifying the organization of assets in done in the:
- Hierarchy window
- Scene view window
- √ Project window
- Inspector window


=========================================================================================================================
Ch 5 - Preparing Assets for Implementation (Materials and Shaders)
This was most difficult so far.

This material property causes polygons to appear and light as if they had more surface detail:
- Emission
- Metallic
- √ Normal
- Smoothness

This material rendering mode uses black in an alpha channel to define where a material is exactly NOT appearing:
- Transparency
- Fade
- Opaque
- √ Cutout 

The albedo of a material is defined as:
- The diffuse color of the material in general light
- The blocking of bounced light by adjacent surfaces
- A raw diffuse color before any weathering is applied
- √ The color of the material without any lighting data

This material property controls spreading of light on microsurface detail:
- Metallic
- Normal
- Ambient Occlusion
- √ Smoothness

The specular property of a material:
- √ Controls the color and strength of reflection
- Controls the spreading of light on microsurface detail
- Defines where surfaces will receive high or low amounts of indirect light
- Modifies the surface to show more detail than the polygons actually have

https://docs.unity3d.com/Manual/StandardShaderMaterialParameters.html


=========================================================================================================================
Ch 6 - Assembling the Game Level

The role of a RayCast is to:
- Provide a placement zone for autonomous agents
- Return ligting information based on normal angle for shaders
- Create obstacles for the player GameObject
- √ Locate Colliders along the path of a ray

Which window allows parenting of GameObjects?
- Project window
- Inspector window
- Scene view window
- √ Hierarchy window

In a Rigidbody, this enables objects to fall:
- Enable mass
- √ Use gravity
- Mass.Apply
- Scene.Gravity

In a Rigidbody component, this determines the air resistance from forces affecting the GameObject:
- √ Drag
- Interpolation
- Collision Detection
- Mass

To add a Box Collider to a GameObject using the top menu, choose:
- √ Components > Physics > Box Collider
- Assets > Create > Colliders > Box
- Physics > Collisions > Box
- Objects > Physics > Box Collider


=========================================================================================================================
Ch 7 - Lighting in Games

What type of light is casting the shape on the wall and floor?
- Point
- √ Directional
- Spot
- Skybox

On a Light Component, a Culling Mask
- √ Determines which layers are affected by the light
- Determines which layer a light is on for rendering
- Shapes the light based on the alpha channel of a textures
- Prioritizes the importance of the light in Deferred Rendering

Changing the intensity of a light adjusts:
- Lumens
- Photometric web
- Color
- √ Brightness

This light emits in a cone, witht he light spreading out as it gets farther from the source:
- Directional
- Point
- Area
- √ Spot

This shadow type casts shadows that approximate the natural fizziness of real shadows due to emission area size and the bouncing of light:
- √ Soft
- Blur
- Area
- Hard


=========================================================================================================================
Ch 8 - Light Baking

Lightmaps:
- √ Store lighting data that has been pre-calculated
- Assigns areas of greater or lesser resolution for baking
- Determines the quality of shadows cast in a game
- Guide the player through the level using lighting

Which kind of file do Lightmaps use to store data?
- TGA
- JPG
- √ EXR
- TIF

Light Probes are used to:
- Determine the necessary specular value of a material
- Measure lighting intesity from a camera placement
- Sample reflection data at specific points in a scene
- √ Sample baked lighting at specific points in a scene

To darken the ambient occlusion in baked lighting:
- Deepen the Dark color towards black
- Decrease the number of GI bounces used
- Increase the Max Distance
- √ Increase the Ambient Occlusion amount

Selecting Generate Lightmap UV in the Import Settings of a models
- Maps the shadow maps to the UV coordinates for shading
- Forces lightmaps to use existing UV coordinates for lighting
- Generates lighting data based on scene lighting inputs
- √ Creates a addition set of UV coordinates for Lightmap data


=========================================================================================================================
Ch 9 - Animating GameObjects in the Unity Editor

This view in the Animation Window allows multiple objects' keys to be shown on horizontal tracks:
- Curve Editor
- √ Dope Sheet
- Animator
- Animation component

When the Unity Editor play controls are red it indicates the Eidtor is in this mode:
- Motion tracking
- real-time effects
- √ Animation record
- Animator settings

Animations are stored in the Unity project as:
- Animator elements
- Motion files
- √ Animation clips
- Animation components

This view in the Animation Window shows animations as graphs:
- √ Curve Editor
- Animator
- Dope Sheet
- Animation component


=========================================================================================================================
Ch 10 - Bringing Animations into the game

Which of the following sequences best describes how you would create a new transition:
- √ Right-click on a state and choose Make Transition
- Right-click in an open area and choose Make Transition
- Shift + drag the animation state onto another state
- Choose Create > Animation > Transition from the menu

Define the role of the Any state:
- A state that applies its behaviors to all states
- A limitless state accessible only by Boolean parameters being true
- An animation that counterbalances any other animations
- √ A state that allows transitions from any other state

Animator Controllers allow you to:
- Animate GameObjects using tangents for speed control
- Create and animate controllers for a GameObject
- Trigger events on an animation timeline by proximity
- √ Arrange and maintain a set of animations for a GameObject

One way to apply an Animator Controller to a GameObject is:
- Click the Insert button with the GameObject selected in the scene
- √ Drag from the Project window onto the GameObject in the inspector
- Click on the GameObject in the scene while holding Alt/Option + Shift
- Drag from the INspector onto the GameObject in the Heirarchy

The default transition is based on:
- End time
- √ Exit time
- Last key
- Speed factor

To create an Animator Controller:
- Right-click the Hierarchy window and choose Create > Animator Controller
- Hold Shift and right-click on any open space in the Inspector
- √ Right-click in the Project window and choose Create > Animator Controller
- Choose Create > Controllers > Animator from the top menu


=========================================================================================================================
Ch 11 - Scripting in Game Development

What data type must be used in the following code? ____ number = 0.8f;
- integer
- √ float
- factor
- string

What type of variable is accessible to other scripts?
- String
- Private
- Integer
- √ Public

Finish the following code to reference the gameObject's position: Vector3 pos = _______;
- gameObject.position
- Vector3 (position)
- √ transform.position
- transform.parent.position

DeltaTime counts seconds between:
- Draw Calls
- √ Frames
- Movements
- Scenes

A method is used to:
- Delineate variables
- Set parameters
- √ Group instructions
- Define classes


=========================================================================================================================
Ch 12 - Pathfinding

What does Max Slope do in navigation:
- Forces a change in animation to climmbing dependent on angle
- Impoements stairs instead of ramps based on angle
- √ Defines the steepest angle that Nav Mesh Agents can walk up
- Sets the downward slop for Nav Mesh Agents to balance on

Which of the following best describes the function of a Nav Mesh?
- Necessary for implementing of a mini-map
- Culls Nav Mesh Agent visibility by line of sight
- √ Defines walkable surfaces for Nav Mesh Agents
- Establishes player-restricted areas

Obstacle avoidance is how Nav Mesh Agents:
- Use scripted behavior of Nav Mesh Agents to duck and jump
- Fold the Nav Mesh to deter agents' movements
- √ Avoid collisions with other Nav Mesh Agents and geometry
- Use static obstacles to limit Nav Mesh Agents' movements


The process of creating a Nav Mesh from the level geometry marked as Navigation Static is called:
- Building
- Implementing
- √ Baking
- Ordering


=========================================================================================================================
Ch 13 - Building the player and allies

In order to define new virtual input axes, you need to configure the key mapping in the:
- Inspector
- Keyboard values
- User input string
- √ Input manager

Which of the following sequnces best describes how you would create an Animator component on an object?
- Click on the Components button and choose Layouts > Animator
- √ Click on the Add Components button and choose Miscellaneous > Animator
- Shift-click on an object in the scene and choose Animations > Animator
- Click on the Components button and choose Animations > Animator Controller

Score accumulation, attacking, and player health are examples of:
- Game Narrative
- √ Game Mechanics
- Audio implementation
- Physics implementation

Which method does not return a value?
- public class Player()
- √ void Start()
- IEnumerator Start()
- bool IsAlive()

The Awake() method is called when:
- An object is enabled
- √ A scene starts
- The physics are calculated
- Meshes are loaded


=========================================================================================================================
Ch 14 - Building the Enemies

In game design, non-player characters are:
- Controlled by other players
- Only in role playing games
- √ Computer-controlled
- Always enemies

Dragging an Animator Controller onto a GameObject in the Inspector creates an:
- Instance Prefab nested
- Animation clip instance
- √ Animator component
- Animation component

A floating point variable is distinguished by what letter immediately following the number?
- √ f
- v
- h
- x

When enabled, which Collider property allows GameObjects to pass through the Collider?
- Use Gravity
- Non-Physic material
- Is Kinematic
- √ Is Trigger

Besides Exit Time, transition conditions can be driven by:
- √ Parameters
- Conditionality
- Interactions
- Animators


=========================================================================================================================
Ch 15 - Particle systems

Circle, Edge, Box, and Cone are examples of:
- Mesh Primitives
- Camera Framing
- Light cookies
- √ Emitter shapes

The Shape section of a particle system defines the geometry of the:
- Forces
- Particles
- Player field
- √ Emitter

In a particle system of smoke, which property is used to change from dense black, to semi-transparent gray, and finally white?
- Change color by duration
- √ Color over lifetime
- Random between two constants
- Inherit Light from Parent

To create an effect showing multiple particles spawning from the originals, you would use:
- Particle splitter
- Child-branch
- √ Sub-emitter
- Cloned system

Which Emit From option allows particles to originate from anywhere withing the emitter geometry?
- Volume shell
- Base
- Base shell
- √ Volume


=========================================================================================================================
Ch 16 - Audio

To make a sound play over and over, which of the following needs to be checked?
- Continuous
- Replay
- √ Looping
- Repeating

To simulate the echoing and distortion of a type of sound environment such as cave, arena, or forest, which of the following audio components would be the best option to use?
- Audio Listeners
- Soundscapes
- √ Reverb Zones
- Flange Filters

Which option begins playing the sound as soon as the GameObject loads?
- Begin on Start
- Wake on Opening
- Sound.PlayOnEnter
- √ Play on Awake

To modify the volume of an audio clip, the clip must be applied to: 
- The amplitude of an audio mixer
- An audio clip modifier
- A sound propertis component
- √ An audio source component


=========================================================================================================================
Ch 17 - Character Selection

A _______ executes a set of instructions and can either return a value or not return a value.
- Pragma
- √ Method
- Variable
- Subroutine

This Transition Parameter type is reset by the controller when consumed by a transition:
- Float
- Integer
- √ Trigger
- Bool

Which method gets a reference to a component on a GameObject?
- GameObject.Find
- FindComponent
- √ GetComponent
- Component.Reference

In this line of code, which of these does not set the playerPosition to 0,0,0?
Vector3 playerPosition = ______;
- Vector3.zero
- √ Vector3(0)
- √ new Vector3.default
- new Vector3 (0,0,0)

To create this placeholder for animation in the Animation indow, you would first right-click in anu open area. Your next action would then be to choose:
- Create > State
- √ Create > Empty
- New from Blend Tree
- Make > New


=========================================================================================================================
Ch 18 - UI

What method is called when this button is clicked (image showing On Click with Player (Audio Source) AudioSource.Play)?
- Runtime Only
- Player.OnClick
- Button.Play
- √ AudioSource.Play

In the image shown, what has caused the change in property names of the Rect Transform (image showing middle-center vs. custom-custom anchors - anchor values in second image are changed)
- Choosing screen space
- √ Splitting the anchor
- Moving the pivot
- Adding a slider

Some of the available options for the Transition property of a button are:
- √ Sprite Swap and Color Tint
- Animator and Animation
- Color Over Life and None
- Sprite Tinit and Animator

In which UI component would you use a Sprite?
- Texture
- Button
- Raw Image
- √ Image

Which component allows the canvas to resize with a display?
- Canvas transform
- Rect transform
- √ Canvas Scaler
- Event System


=========================================================================================================================
Ch 19 - Building

Android, web, and iOS are some of the supported platforms for:
- √ Unity Cloud Build
- Performance monitoring
- Unit Ads
- Rapid Sync

Which identifier is used to link a project data feed to Unity Analytics?
- Project Name
- Scene Name
- √ Project ID
- ID Certificate

In order to utilize Unity Cloud Build, your project must be synced to:
- Unity Asset Server
- Network Attached Storage
- √ A source control repository
- An external hard drive

An image for an image component must be imported as this type:
- √ Sprite
- PNG
- Alpha
- Texture

Differentiate between Rewarded and Simple Ads:
- √ Rewarded Ads cannot be skipped by default
- Simple Ads are static images
- Simple Ads are unlimited
- Rewarded Ads provide more money per click

# EBAC Unity & Game Dev Journey 


This repository documents my learning journey through the **Game Development Course by EBAC**.

Here, I apply core concepts of **C#**, **Unity Engine**, and **Game Design** patterns.


---


##  Manipulation Shortcuts (Tools)


Building "muscle memory" for Scene navigation using the **QWERTY** layout:


| Key | Tool | Technical Name | Function |
| :---| :---|:---|
| **Q** | Hand | **Pan / View** | Navigate the scene without affecting objects. |

| **W** | Arrows | **Move** | Translation (Move along X, Y, Z axes). |

| **E** | Circles | **Rotate** | Object rotation. |

| **R** | Block | **Scale** | Resize object dimensions. |

| **T** | Rectangle | **Rect Tool** | UI and 2D Sprite adjustments. |

| **Y** | All | **Transform** | Move, Rotate, and Scale simultaneously. |


---


## Interface Structure


Core concepts of the Unity Workspace:


* **Scene:** The "film set". Where we build the world level.

* **Hierarchy:** The list of GameObjects currently **active** in the scene.

* **Project:** The file cabinet. Contains all assets, scripts, and materials (The ingredients).

* **Inspector:** Displays detailed properties and components of the selected object.

* **Console:** Output for logs, warnings, and debug errors.


---


## Module 3: Primitives & Lighting


Notes on handling basic 3D objects, coordinate systems, and scene illumination.


![Lighting Notes](./Lights on and shadows.png)


###  Primitives & Coordinates

* **Primitives:** Basic 3D shapes provided by Unity (Cube, Sphere, Capsule, Plane).

* **Coordinate Systems (Position):**

    * **Local Space:** Position relative to the **Parent** object (Child/Local).

    * **World Space:** Position relative to the **Global** scene origin (General).


### Lighting System

* **Directional Light:** Simulates the **Sun**. Infinite distance, affects the entire scene globally.

* **Point Light:** Spherical light source. Illuminates objects within a specific range/radius (like a lightbulb).

* **Properties:** Manipulation of Light Color (e.g., Blue/Green setup) and Intensity.

* **Shadows:** Configuration of Shadow Types (Hard vs. Soft).


---

### Module 4: Game Objects & Prefabs

Understanding the building blocks of Unity and how to scale development using templates.

| Concept | Technical Definition | Mental Model (Analogy) |
| :--- | :--- | :--- |
| **Game Object** | The base container for everything in a scene. It does nothing without components. | **The Plate:** It's empty until you add "Food" (Components like Mesh, Light, Script). |
| **Prefab** | A reusable asset stored in the Project. It acts as a "Master Template" for Game Objects. | **The Recipe Card:** If you change the ingredient in the recipe (Prefab), all dishes served (Instances) update automatically. |
| **Instance** | A clone of a Prefab that exists in the Scene. | **The Dish on the Table:** A specific copy of the recipe served to the player. |
| **Collider** | A component that defines the physical shape for collisions. | **The Force Field:** Makes the object "solid" so others can bump into it. |
| **Tag** | A reference label to identify objects (e.g., "Player", "Enemy"). | **The Name Badge:** Helps the code find specific objects in a crowded room. |

---

### Workflow & Tips

#### 1. Creating a Prefab
* **Action:** Drag a Game Object from **Hierarchy** > Drop into **Project Folder**.
* **Visual Cue:** The Icon in Hyerarchy turns **blue** (Linked to Prefab).
* **Best Practice:** Awalys edit the *Prefab Asset* (in the folder ) to update all instance at once.
#### 2. Visual Labels (Gizmos)
* **Problem:** Hard to find invisible objects (like Lights or Logic Managers) in the Scene.
* **Solution:** Use **Gizmo Icons** (The colored bubbles).
* **How to enable in Unity 6:**
    1. Inspector: Click the **Icon Box** to the left of the object name.
    2. Scene View: Click the **Gizmos Globe** (Top Right) to toggle visibility.
    3. *Tip:* Adjust the "3D Icons" slider if labels are too big/small. 

---

## Module 5: Assets & Package Management

Managing external recourses and plugins.

| Tool | Function | Mental Model (Analogy) |
| :--- | :--- | :--- |
| **Asset Store** | The marketplace to download 3D models, sounds, and tools. | ** The Shopping Mall.** You go there to buy ingredients or furniture.
| **Package Manager** | The internal tool to install/update Unity features(like ProBuilder, URP/HDRP). |
| **Importing** | Bringing files into the project. | **Unpacking:** Taking the furnitune out of the box and putting it in the living room. |

---

## Module 6: Materials & Variants ( Visual Inheritance)

Understanding how to manage textures and colors efficiently using inheritance.

| Concept | Definition | Metal Model ( Analogy) |
| :--- | :--- | :---  |
| **Material** | Defines how an object looks (Color, Shininess, Textures). | **The Paint Bucket:** Applying "Red Glossy Paint" to a car. |
| **Material Variant** | A child material that inherits properties from a Parent Material but can have specific overrides. |**The Uniform:** "Base Uniform" is black. "Manager Uniform" inherits the black fabric but overrides the button color to Gold. |
| **Hierarchy Logic** | Parent changes affect all Children. Child changes only affect the Child. | **The DNA:** If the father changes species, the son changes. If the son dyes hair, the father stays the same. |

---
## Module 6.1: DevOps & Cloud Workflow

Professional workflow for version control and automated builds.

| Concept | Definition | Flow Analogy |
| :--- | :--- | :--- |
| **Unity Version Control** | The system that tracks changes (like Git but optimized for big files). | **The Time Machine:** Lets you undo mistakes or travel back to a working version. |
| **Cloud Build** | A server that builds the game (`.exe` / `.apk`) for you. | **The Factory:** You send the blueprints (Code), and the factory delivers the finished product (Game) while you keep working. |
| **LTS** | **Long Term Support** version. | **The Foundation:** A stable version of Unity that won't change or break features for 2+ years. |

---

## Module 7: Overrides & Prefab Management

Handling exceptions in the Prefab workflow.

* **The "+" Icon:** Indicates a **Local Override**. The object has modifications specific to *this scene* that are not in the original Prefab.
* **Apply All:** Pushes the local changes back to the Master Prefab (updates the "Factory Blueprint").
* **Revert All:** Discards local changes and resets the object to match the Master Prefab.  

---

## Module 9: Data Persistence (PlayerPrefers)

Saving simple data ( High Score, Settings, Last Position) so it survives after the game closes.

| Command | Syntax Example | Mental Model ( Analogy) |
| :--- | :--- | :--- | 
| **Set(Save)** | `PlayerPrefs.SetFloat("Key", Value) ;` | **Writing in the Notebook:** You write down the number so you don't forget. |
| **Get (Load)** | `PlayerPrefs.GetFloat("Key" Default);` | **Reading the Notebook:** You look for the page "Key". |
| **Default Value** | `GetFloat("Score", 0 );` | **The Fallback:** if the page is blank (first time playing ), assume the score is 0. |

---

## Module 10: Performance & Optimization

Ensuring the game runs smoothly (Target: 60 FPS).

| Tool | Path | Function | Mental Model (Analogy) |
| :--- | :--- | :--- | :--- |
| **Profiler** | `Window > Analysis > Profiler` | Analyzes CPU, GPU, and Memory usage frame by frame. | **The Medical Scan:** Shows exactly which organ (script/physics) is sick/slow. |
| **Frame Debugger** | `Window > Analysis > Frame Debugger` | Pauses a single frame to see how it's drawn layer by layer. | **The Slow-Motion Replay:** Lets you see if you are drawing things you don't need (like invisible walls). |
| **Stats** | `Game View > Stats` | Quick overlay showing current FPS and Batches. | **The Speedometer:** A quick check to see how fast you are going. |

* **Key Metric:** **60 FPS** (Frames Per Second) is the gold standard for smooth gameplay.
* **Green Spike in Profiler:** Usually indicates **Rendering** issues (Textures too big, too many lights).

---

## Module 11: Tools & Recording

Essential tools for Game Design documentation.

* **Unity Recorder:** An add-on to record gameplay directly inside the engine without losing quality.
    * *Use Case:* Creating trailers or debugging physics glitches.
* **Static Objects:** Checking the `Static` box tells Unity "This object never moves".
    * *Benefit:* Unity pre-calculates lighting and physics, saving massive CPU power.

---

## Module 12: Cinemachine (Camera System)

Advanced camera control without writing code.

| Component | Function | Mental Model (Analogy) |
| :--- | :--- | :--- |
| **Virtual Camera** | Calculates where the camera *should* be. | **The Gimbal / Drone:** It's not a camera (it has no lens). It's a robotic arm that flies around. |
| **Cinemachine Brain** | Links the Main Camera to the Virtual Cameras. | **The Pilot:** He sits inside the Main Camera and steers it to match the Gimbal's position instantly. |
| **Follow** | Determines the target position (X, Y, Z). | **The Leash:** Pulls the camera along with the target object. |
| **Look At** | Determines the target rotation (Angle). | **The Head:** Keeps the camera's "eyes" locked on a specific point. |
| **Priority** | Determines which Virtual Camera is active. | **The Loudest Voice:** The camera with the highest number (e.g., 15 vs 10) wins control. |

---

## Module 13: Animation Systems

Bringing objects to life via Keyframes, State Machines, or Code.

| Tool | Type | Use Case | Mental Model (Analogy) |
| :--- | :--- | :--- | :--- |
| **Animation (Clip)** | Legacy / Linear | Simple movements (Door opening, Platform moving). | **The Tape:** A recorded sequence of frames. Like a GIF. |
| **Animator** | State Machine | Complex character logic (Walk -> Run -> Jump). | **The Flowchart:** The "Brain" that decides *which* Tape to play based on conditions (Parameters). |
| **Keyframe** | Data Point | A snapshot of properties (Position, Scale) at a specific time. | **The Pose:** "At second 0, stand here. At second 1, stand there." |
| **DOTween** | Code (C#) | Smooth, mathematical transitions (UI Fading, Popups). | **Telekinesis:** Moving things using pure math formulas (Easing) instead of manual recordings. |

---

## MODULE 14:  WHAT ARE VARIABLES?

**It is a MEMORY ALLOCATION.**

### Types of Vars
* `Int Level = 1;` -> Integer (`Int Doors = 4`)
* `Float Life = 1.0;` -> Floating point, accepts broken numbers.
    * *C#* -> `Float Name = xf;` (A declaration of a broken value).
* `Bool HasGun = false;` -> Boolean Logic (True or False).

### Variable Visibility (Types)

| **PRIVATE** | **PUBLIC** | **PROTECTED** |
| :--- | :--- | :--- |
| **Not Visible.** | **Visible.** | **Visible only with Inheritance.** |
| Accessed only by the class itself. | Accessed through all classes. | Only classes that use Inheritance have access. |
| *Symbol:* `_name` (Underscore -> Way to filter). | | |

---

###  C# STRUCTURE

1.  **Part 1: The Toolboxes** (`using UnityEngine;`)
2.  **Part 2: The Badge/ID (Who am I)** (`public class ...`)
    * *File Name and Object Definition.* (The Class name must match the file).
3.  **Part 3: The Filling (Data and Actions)**
    * *Everything that happens in the game stays inside brackets `{}`.*
    * **Functions and Methods:** They are Orders / Instructions.
    * `Start {}` -> Preparations.
    * `Update {}` -> Action.

---

## # OOP CONCEPT (Object Oriented)

**What is it?** One of the goals is to be **SCALABLE**.
> **"Drawer Organization"**

```csharp
Class Name {
   - Attributes
   - Methods
};


## 15. Métodos Básicos da Unity (Lifecycle)
> Baseado nas anotações de estudo.

Por padrão, ao herdar de `MonoBehaviour`, temos acesso a um ciclo de vida de execução:

### Ordem de Execução
1.  **Awake:** Chamado **antes de tudo**, antes mesmo do Start. É usado para inicializar variáveis ou referências internas.
2.  **OnEnable:** Chamado toda vez que o objeto é ligado (ativado).
3.  **Start:** Chamado após o Awake e antes do primeiro Update. Usado para lógica inicial.
4.  **Update:** Chamado **1x por frame**. A frequência varia (15 FPS a 60 FPS+). Usado para inputs e lógica de jogo.
    * **FixedUpdate:** Trabalhar com **Física**. É chamado em intervalos fixos, independente do frame rate.
    * **LateUpdate:** Chamado **após** o Update. "Ele espera" o Update terminar. Ótimo para câmeras seguirem o jogador.

### Outros Métodos Importantes
* **OnDisable:** Chamado toda vez que o objeto é desligado.
* **OnDestroy:** Chamado quando o objeto é destruído.
* **Física:**
    * `OnCollisionEnter`, `OnCollisionStay`, `OnCollisionExit` (Colisão física).
    * `OnTriggerEnter`, `OnTriggerStay`, `OnTriggerExit` (Gatilhos/Sensores).

---

## 16. Input System (Detectando Teclas)
Como detectar entradas do teclado, mouse e joystick.

### Tipos de Leitura
Podemos ter várias funções com 'n' possibilidades. O Input nunca é *Down* e *Up* ao mesmo tempo.

* `Input.GetKeyDown(KeyCode.Space)`: Retorna `true` apenas no frame que a tecla **começou** a ser pressionada.
* `Input.GetKeyUp(KeyCode.Space)`: Retorna `true` no frame que a tecla foi **solta**.
* `Input.GetKey(KeyCode.Space)`: Retorna `true` enquanto a tecla estiver sendo **segurada**.

### Otimização Lógica
Se eu recebi o `Up`, eu não preciso verificar o `Down` no mesmo frame. Use `else if` para economizar processamento.

```csharp
if (Input.GetKeyUp(KeyCode.Space))
{
    ChangeColor(Color.blue);
}
else if (Input.GetKeyDown(KeyCode.Space)) 
{
    // Só verifica se o de cima for falso
    ChangeColor(Color.magenta);
}

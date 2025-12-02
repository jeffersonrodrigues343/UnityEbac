
# EBAC Unity & Game Dev Journey 


This repository documents my learning journey through the **Game Development Course by EBAC**.

Here, I apply core concepts of **C#**, **Unity Engine**, and **Game Design** patterns.


---


##  Manipulation Shortcuts (Tools)


Building "muscle memory" for Scene navigation using the **QWERTY** layout:


| Key | Tool | Technical Name | Function |

| :---: | :--- | :--- | :--- |

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




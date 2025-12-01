
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


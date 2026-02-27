# Kope's SpriteComposer 2D

[**© 2026 Keshav Prasad Neupane ("Kope")** **License:**](LICENSE.md) [MIT License](https://opensource.org/licenses/MIT)

---

## 🌟 The Spirit of the Project
This project was created for the purpose of learning and creating a modular system for Unity 2D. It is made open-source to respect the **LPC (Liberated Pixel Cup)** spirit and freeness due to the use of their assets during creation. It provides a generic, data-driven architecture that bridges the gap between raw spritesheets and synchronized modular animation.

## 📖 Overview
**Kope's SpriteComposer 2D** is a comprehensive framework for Unity designed for modular character assembly. It allows developers to build characters from independent body parts and equipment while keeping animations perfectly synchronized through a data-driven, performant approach.

> [!TIP]
> **Starter Kit Included:** To help you get started immediately, the project includes **Example Concrete Classes**, **Dummy Animation Assets**, and **Sample Sprites**. These are intended to serve as blueprints and templates for your own custom implementations.

---

## 🚀 Key Features

### High-Performance Runtime
* **Intelligent Resolution:** Resolves correct sprite libraries based on Race, Gender, and Variant using $O(1)$ HashSet lookups.
* **Dynamic Equipment:** Real-time equipping/unequipping with automatic animation synchronization.
* **Layered Fallbacks:** Automatically reverts to base body libraries when equipment is cleared.
* **Deterministic Sync:** Ensures all independent body regions (head, torso, legs, etc.) stay visually in sync during complex animation states.

### Professional Editor Suite
* **Grid Auto Slicer:** Mass-slices spritesheets into named animation frames based on row templates.
* **Library Populator:** Automatically generates `SpriteLibraryAssets` from templates, preserving complex structures instantly.
* **Animation Snap Tool:** Instantly aligns modular parts to specific frames for testing. **Supports Unity Animator Recording Mode** for rapid keyframing.

---

## 🛠 Technical Design Philosophy
* **Generic & Modular:** Uses Generics (`TPart`) to remain agnostic to your specific body parts—customize the enums and the framework adapts.
* **Enum-Based Pipeline:** Uses strictly defined ID gaps (e.g., 0-499, 500-999) in enums to allow massive expansion without breaking existing data.
* **Fail-Fast Validation:** Includes `OnValidate` logic to catch invalid library setups before they ever reach a game build.

---

## 📋 Usage Flow

### 1. Asset Preparation
1. Prepare your spritesheets (use the provided **LPC-compatible example sprites** or your own).
2. Define **Row Naming Data** assets to match your sheet layout.
   * *See `animation_row_name_template_asset` for an example.*
3. Slice and auto-name frames using the **Grid Auto Slicer** (`Tools > Grid Auto Slicer`).

### 2. Sprite Library Generation
1. Create a "Dummy" `SpriteLibraryAsset` to act as your animation template.
   * *A dummy asset `base_dummy_animation_asset` (Idle, Walk, Thrust, Spell, Swing) is included.*
2. Use the **Populator** (`Tools > Populate Library From Dummy`) to map your sliced textures to the template.
3. Convert the output to `.spriteLib` using the Unity Asset Upgrader.

### 3. ScriptableObject (SO) Configuration
To make the libraries usable by the resolver, wrap them in ScriptableObjects. Use the **example concrete SO classes** provided:
1. Create a Body or Equipment asset via: `Create > Animation > BodyRegionAsset` or `EquipmentAsset`.
2. Fill in the **Variant Name**, **Gender**, **Race Whitelist**, **Body Part**, and **Color** type.
3. Assign your generated `.spriteLib` to this SO.

### 4. Assembly & Testing
1. Attach the provided **Example Resolver** (`StaticAnimationLibraryResolver`) or your own custom resolver to your character prefab.
2. Assign your configured **SO Assets** to the resolver.
3. Use the **Snap Tool** to preview animations. Toggle **Record Mode** in the Unity Animator to save these snaps as keyframes automatically.

---

## ⑄ Optimization: Better Y-Sorting
To prevent modular parts from flickering or sorting incorrectly:

* **Sorting Layers:** Create a layer named `Actor` or `Entity`.
* **Project Settings:** In *Graphics > Transparency Sort Mode*, set to `Custom Axis` (**X:0, Y:1, Z:0**).
* **Pivots:** Ensure Sprite Renderers use `Pivot` for sorting. (The included `SetSpriteToPivot` script automates this).
* **Canvas Grouping:** Add a `Canvas Group` to the parent GameObject of your modular parts. This forces Unity to treat the entire character as a single unit for sorting purposes.

---

## ⚖️ License Summary
This framework is available under the **MIT License**—**for the custom code only**.

### Scope of the MIT License
The MIT License applies **exclusively** to:
* C# source code written for this framework
* Editor tools and runtime systems created for this project
* Custom framework logic and architecture

### What is NOT Covered
* **Unity Engine Core:** Unity is governed by [Unity's licensing terms](https://unity.com/legal/terms-of-service)
* **Third-party Dependencies:** Any NuGet packages, plugins, or external libraries follow their own licenses
* **LPC Assets:** [Included LPC sprite assets follow their own **GPL v3.0 / CC BY-SA 3.0 licenses**](CREDITS.csv)
* **Other Third-Party Content:** Any licensed assets or tools integrated into this project retain their original licensing

### Attribution
While not legally required by the MIT License, I'd appreciate a shout-out to **Kope's SpriteComposer 2D** in your project's credits if you use this framework!


---

## Author Links
* [**GitHub**](https://github.com/KeshavPsdNeupane)
* [**LinkedIn**](https://www.linkedin.com/in/keshav-prasad-neupane-259542318/)
* [**YouTube**](https://www.youtube.com/@KeshavPsdNeupane)
# Multiplayer Augmented Reality (AR) Game Development 

Welcome to the **Multiplayer AR Game Development** repository! This project showcases a complete multiplayer augmented reality game that I developed using Unity, AR Foundation, and Photon Unity Networking (PUN 2). The game leverages the latest in AR technology—including Google’s ARCore and Apple’s ARKit—to create an immersive, cross-platform experience.
(Video Link :- https://drive.google.com/file/d/1-fye1Nn2d7cj-NMTuZVON5B1YR8MtVcd/view?usp=sharing)

---

## Overview

This project combines robust multiplayer networking with cutting-edge augmented reality features. I built the game to demonstrate how to integrate real-time multiplayer gameplay with AR elements on both Android and iOS devices. The development journey included creating a single-player prototype, implementing networked multiplayer using Photon, and integrating AR functionalities that detect surfaces and synchronize game elements in real-world environments.

---

## What We Have Done

### Multiplayer Implementation

- **Photon Unity Networking (PUN 2):**  
  I connected the game to Photon servers, allowing players to join random rooms seamlessly. Custom scripts handle player instantiation, movement synchronization, and real-time interactions.
  
- **Player Management:**  
  The project features a comprehensive player selection system, manual player spawning, and mechanisms for handling in-game events such as player elimination and respawning.

### Augmented Reality Integration

- **AR Foundation with ARCore & ARKit:**  
  I integrated Unity’s AR Foundation to build a unified AR experience. The game automatically detects flat surfaces using ARCore on Android and ARKit on iOS, allowing the arena to be placed accurately in the real world.

- **Dynamic AR Interactions:**  
  The game supports scaling of in-game assets, and the AR environment is fully synchronized with player movements, ensuring a smooth and immersive multiplayer experience.

### Unity & C# Development

- **Physics & Scene Management:**  
  The project utilizes Unity’s physics engine for realistic interactions and includes efficient scene loading techniques to maintain performance during gameplay.
  
- **Custom Scripting:**  
  I wrote custom synchronization scripts to ensure that player movements and interactions are accurately reflected across the network, providing a seamless multiplayer experience.

---

## Requirements / Prerequisites

To run and build this project, you’ll need:

- An **ARCore-supported** Android device or an **ARKit-supported** iPhone/iPad.
- **Unity 2019.3** or later.
- Intermediate experience with **C#** and **Unity**.
- A configured **Photon Unity Networking (PUN 2)** account and App ID for multiplayer functionality.

---

## Getting Started

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/multiplayer-ar-game.git
   ```

2. **Open the Project in Unity:**
   - Use Unity 2019.3 or later.
   - Open the project folder.

3. **Install Required Packages via Package Manager:**
   - AR Foundation  
   - ARCore XR Plugin (for Android)  
   - ARKit XR Plugin (for iOS)  
   - Photon Unity Networking (PUN 2)

4. **Configure Project Settings:**
   - Enable the appropriate XR Plug-in Management settings for your target platform.
   - Input your Photon App ID in the Photon settings.

5. **Build & Run:**
   - **For Android:** Switch to the Android platform, enable ARCore, and build.
   - **For iOS:** Switch to the iOS platform, enable ARKit, and build.

6. **Test the Game:**
   - Ensure your device supports ARCore or ARKit.
   - Launch the game, detect surfaces, and experience the AR multiplayer arena.

---

## Roadmap / Future Enhancements

- **Advanced AR Interactions:** Adding gesture controls and object manipulation.
- **Enhanced Multiplayer Features:** Implementing matchmaking, lobby systems, and cross-platform play.
- **In-Game Communication:** Integrating chat or voice communication for a more connected experience.
- **Performance Optimization:** Further optimizing the game for smoother performance on all supported devices.

---

## Contributing

Contributions, bug reports, and feature requests are welcome! To contribute:

1. Fork the project.
2. Create a new branch (`git checkout -b feature/my-feature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/my-feature`).
5. Open a Pull Request.



# WhiskerRun

WhiskerRun is a 2D Unity endless runner where a cat jumps through a side-scrolling obstacle course while the score and game speed climb over time.

## Overview

This project is a compact arcade game built in Unity. The player starts a run with the spacebar, jumps over hazards, earns score based on distance survived, and can retry after colliding with an obstacle. The project is intentionally small, making it easy to inspect the complete gameplay loop, scene setup, prefabs, sprites, and UI flow.

## Key Features

- Side-scrolling endless runner gameplay
- Spacebar jump input with gravity-based movement
- Randomized obstacle spawning with configurable spawn chances
- Increasing game speed and distance-style scoring
- Persistent high score stored with Unity `PlayerPrefs`
- Game start, game over, and retry UI states
- Camera background color selector UI
- Unity 2D project using Universal Render Pipeline

## Tech Stack

- Unity `6000.1.0f1`
- C#
- Unity Input System package
- Universal Render Pipeline
- TextMesh Pro

## Requirements

- Unity Hub
- Unity Editor `6000.1.0f1` or a compatible Unity 6 editor
- Git, if cloning from GitHub

Unity package dependencies are tracked in [Packages/manifest.json](Packages/manifest.json). Unity will restore package dependencies when the project is opened.

## Setup and Run

1. Clone the repository:

   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```

2. Open the project in Unity Hub.

3. Use Unity Editor `6000.1.0f1` when prompted, or allow Unity to upgrade only after reviewing package compatibility.

4. Open the main scene:

   ```text
   Assets/Scenes/WhiskerRun.unity
   ```

5. Press Play in the Unity Editor.

6. Press `Space` to start and jump.

## Environment Variables

This project does not require runtime environment variables. A [.env.example](.env.example) file is included as a placeholder for future services such as analytics, leaderboards, or build automation.

Do not commit real `.env` files or secrets.

## Project Structure

```text
Assets/
  Fonts/          Custom and TextMesh Pro font assets
  Materials/      Materials used by scene objects
  Prefabs/        Reusable obstacle prefabs
  Scenes/         Main Unity scene
  Scripts/        C# gameplay and UI scripts
  Settings/       Render pipeline and scene template settings
  Sprites/        2D art assets for the player, obstacles, and UI
Packages/
  manifest.json   Unity package dependencies
ProjectSettings/  Unity editor and project configuration
```

## Future Improvements

- Add a short gameplay GIF or screenshot to the README.
- Add sound effects, background music, and volume controls.
- Add mobile touch input support.
- Add a main menu with difficulty selection.
- Add unit or play mode tests for score, spawn timing, and game state transitions.
- Add a WebGL build workflow for browser-based demos.
- Replace placeholder/simple sprites with a consistent final art style.
- Add a credits/license section for all third-party assets and fonts.

## Author

Created by Minh.

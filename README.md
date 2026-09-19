# 🚀 NSI Missile Cup

A Unity-based arena game project inspired by the fast-paced, competitive feel of Rocket League. This repository contains a playable prototype with team scoring, camera switching, lobby navigation, pause controls, and a simple game-flow structure.

## Overview

NSI Missile Cup is a school project focused on creating an arcade-style sports game experience where players compete to score goals in a stylized arena. The project uses Unity's modern tooling and includes core gameplay systems such as:

- score tracking for two teams
- camera switching between perspectives
- lobby and scene transitions
- pause menu functionality
- UI feedback for match results

## Features

- Two-team score system with red and blue teams
- Match win state and automatic return to lobby
- Multiple camera views via Cinemachine
- Pause menu support
- Simple UI-driven transitions between scenes
- Unity project set up for rapid iteration and prototype development

## Project Structure

```text
NSI-Missile-Cup/
├── Assets/
│   ├── Ball/
│   ├── Prefabs/
│   ├── Resources/
│   ├── Scenes/
│   ├── Settings/
│   ├── Sprites/
│   ├── Stylized Car/
│   ├── TextMesh Pro/
│   ├── scripts/
│   └── ...
├── Packages/
├── ProjectSettings/
├── .gitignore
├── .gitattributes
├── ignore.conf
├── README.md
└── ...
```

## Main Scripts

The project includes several gameplay and UI scripts, including:

- `ScoreManager.cs` — tracks goals, updates score UI, and handles round/win flow
- `CameraSwitcher.cs` — switches between active cameras
- `Pause.cs` — controls in-game pause behavior
- `Chat.cs` — likely handles in-game chat or messages
- `toGame.cs`, `toLobby.cs`, `Back.cs`, `quitGame.cs` — scene navigation and menu actions

## Unity Version

This project was created with:

- Unity `6000.0.28f1`

## How to Run

1. Clone the repository.
2. Open the project in Unity.
3. Make sure your Unity version matches the project configuration.
4. Load the main scene in the `Assets/Scenes` folder.
5. Press Play to test the game.

## Controls

Controls are defined in the Unity project settings and are likely configured through the Input Manager. You can customize them in the project settings if needed.

## Notes

This is a prototype/school project and may still be evolving. Some elements may be incomplete or require asset setup depending on the local Unity environment.

## License

This project does not currently include a license file. If you intend to publish or share it publicly, consider adding one.

## Author

MoCorps

## Status

Work in progress / prototype project.

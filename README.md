# 3D Obstacle Course Challenge

A first-person 3D obstacle course game with movement mechanics, a chat system, and trophy collection.

## Installation

1. **Download Latest Release**
   - Visit [the release page](https://github.com/ludicrouslytrue/first-person-3d-level/releases/tag/v2.0)
   - Download `First.Person.3D.level.v2.0.zip ` from Assets
   - Extract and run `First Person 3D level.exe`

2. **Build From Source**
- Requires Unity 2022.3.50f1 or newer
- Clone this repository to any folder
- Open that folder as a project in Unity Editor
- Build via File > Build Settings

## Features

- **Core Movement Mechanics**
  - WASD movement
  - SPACE to jump
  - LEFT CTRL to crouch
  - LEFT SHIFT to sprint
  
- **Challenging Obstacle Course**
  - Platforming challenges requiring precise jumps
  - Crouch tunnels and sprint sections
  - Multiple difficulty paths

- **Real-Time Chat System**
  - Press ENTER to open/close chat
  - Send messages displayed in the chat
  - Chat history scrollable in-game

- **Trophy Collection**
  - Interactive trophy at course end
  - "Press E to pick up" tooltip when near
  - Trophy appears in player's hand on collection
  - Auto-sends victory message to chat

- **Respawn System**
  - Auto-respawn at start if falling into void (Y < -1)
  - Keep collected trophy on respawn
  - Position reset to (0, 5, 0)

## Controls

| Action          | Key           |
|-----------------|---------------|
| Move            | W A S D       |
| Jump            | SPACE         |
| Crouch          | LEFT CTRL     |
| Sprint          | LEFT SHIFT    |
| Open/Close Chat | ENTER         |
| Interact        | E             |

## How to Play

1. Navigate the obstacle course using movement abilities
2. Reach the final platform with the trophy
3. Approach trophy and press E to collect
4. Use chat to celebrate your victory!

### Trophy Interaction
1. Approach golden trophy at course end
2. Look directly at trophy to see tooltip
3. Press E to collect
4. Trophy appears in your hand
5. Victory message sent to chat

### Respawn System
- Fall below Y=-1 to auto-respawn at start
- Keep collected trophy between respawns
- Full position reset to (0, 5, 0)

## Credits
- Developed by Divyam Agrawal
- Unity 3D Project 
- Built with Unity Engine 2022.3.50f1

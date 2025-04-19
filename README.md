Snake Game

This is a classic Snake game implemented in **C#**. The game allows players to control a snake, collect food, and grow in size while avoiding collisions with walls or the snake's own body.

## Table of Contents

1. [Features](#features)
2. [Installation](#installation)
3. [Usage](#usage)
4. [Code Overview](#code-overview)
5. [Contributing](#contributing)
6. [License](#license)

---

## Features

- Classic Snake game mechanics.
- Adjustable game speed/difficulty.
- Collision detection for walls and self.
- Scoring system based on collected food.
- Simple, interactive console-based user interface.

---

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Atmoloid/Snake-game.git
   ```
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build the solution to restore dependencies.
4. Run the application.

---

## Usage

1. Launch the game by running the executable or starting the project in your IDE.
2. Use the keyboard arrow keys to control the snake.
3. Collect food to score points and grow the snake.
4. Avoid colliding with walls or the snake's body.

---

## Code Overview



### 1. **Game Entry Point**
   - The main entry point of the application is located in the `Program.cs` file.
   - It initializes the game loop and handles the application lifecycle.

### 2. **Game Logic**
   - The "Program.cs", "Coord.cs" and "direction.cs" file contains the logic for the Snake game, including:
     - Snake movement.
     - Collision detection.
     - Food spawning.

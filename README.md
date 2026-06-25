# 🎲 Dice Roll Game

A simple console-based dice guessing game built with C# and .NET 10.

## How to Play

1. Choose the number of attempts (1–4)
2. Guess which number (1–6) the dice landed on
3. Keep guessing until you get it right or run out of attempts
4. Choose to play again or exit when the round ends

## Features

- Input validation — rejects out-of-range numbers, letters, and empty input
- Configurable difficulty — pick how many attempts you get before starting
- Play again — restart without relaunching the app
- Emoji feedback 😁😢😔

## Project Structure

```
Dice-Roll-Game/
├── Models/
│   └── Game.cs          # Game state (attempts, random number)
├── Services/
│   └── GameService.cs   # Core game logic
├── UI/
│   ├── InputHandler.cs  # Reading and validating user input
│   └── MessagePrinter.cs # All console output
└── Program.cs           # Entry point
```

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Run the game

```bash
git clone https://github.com/AbbasZandi97/dice-roll-game.git
cd Dice-Roll-Game/Dice-Roll-Game
dotnet run
```

## Concepts Practiced

- **Object-Oriented Programming** — splitting responsibilities across classes (Game, GameService, InputHandler, MessagePrinter)
- **Separation of Concerns** — distinct layers for game logic, UI output, and user input
- **Encapsulation** — using private setters and methods to protect game state
- **Loops & Control Flow** — nested `do-while` loops to manage game rounds and the play-again flow
- **Input Validation** — handling invalid, out-of-range, and empty user input gracefully
- **Static vs Instance members** — UI utility classes use static methods; game state lives in an instance
- **Namespaces & Project Structure** — organizing code into logical folders and namespaces

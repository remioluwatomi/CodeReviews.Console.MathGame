
# Console Math Game

## 📝 Description

An interactive console-based Math Game App.

## ⭐ Features

- **Multiple Operation Modes:**
  - Addition (`+`)
  - Subtraction (`-`)
  - Multiplication (`*`)
  - Division (`/`)
  - Random Mode (mixes all operations)
- **Progress Tracking**
- **Game History**
- **Emoji Feedback** (✅ for correct, 🗙 for incorrect)
- **Input Validation**
- **Customizable Question Count**

## 🚀 Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Terminal with Unicode support

### 💻 Installation

```bash
# Clone the repository
git clone https://github.com/remioluwatomi/CodeReviews.Console.MathGame.git

# Navigate to project directory
cd CodeReviews.Console.MathGame.

# Build the project
dotnet build

# Run the game
dotnet run
```

## 🎮 How to Play

1. Launch the game to see the welcome message
2. Enter 'y' to start playing or 'n' to exit
3. Select your game mode:
   - 1: Addition
   - 2: Subtraction
   - 3: Multiplication
   - 4: Division
   - 5: Random Mode
   - 6: View History
   - q: Quit
4. Enter the number of questions you want to attempt
5. Solve each math problem
6. View your score and choose to play again or quit

## 🏗️ Project Structure

```plaintext
Tomi.MathGame
├── Program.cs          # Main game loop and initialization
├── MathCore
    ├── Engine.cs       # Core game logic and operations
    └── Utils.cs        # UI and input handling utilities
```

## 🔧 Technical Details

- Built with C# (.NET)
- Uses tuple data structures
- Implements delegate pattern
- Includes comprehensive input validation
- Maintains session history

## ⚙️ Features In Detail

### Random Number Generation

- Operands range from 1 to 100
- Division problems ensure whole number results

### Score Tracking

- Tracks correct answers per session
- Maintains problem history
- Provides detailed feedback

### User Interface

- Clear console interface
- Emoji-based feedback system
- Input validation

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🙏 Acknowledgments

- This is a solution to C# Academy Math Game Project

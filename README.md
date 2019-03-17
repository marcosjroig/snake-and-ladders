# Snakes & Ladders
C# Console application made in .NET Core for the game: Snakes and Ladders

![](SnakesAndLadder.jpg)

## Requirements to run the code
Visual Studio 2017 or VS Code
.NET Core 2.2 framework

## Solution structure

This solution has two projects:
- A console application and
- XUnit test project for .Net Core

Both projects use Net Core 2.2 Framework.

## Game execution

By executing the Console application from Visual Studio, you will see the log of the players changing position in the board.

This implementation has two players, computer vs computer, that change position randomly, so any player can win.

The log shows the position of the player every time a player rolls a die, and also show a message if it finds a snake or ladder.

In addition, if a player is in the square 98 (considering the last position 100) and rolls a die and get 4, the player will remain in the same position, until get 2 or two times 1.

It is possible that two players land in the same position, when that happens, for my implementation there is no change, so I am not moving down any of the players. Other implements may do.

I didn't implement the option to clean the screen and play again. The main idea I had when starting doing it was to focus more on the Object Oriented part of the game and make it simple.

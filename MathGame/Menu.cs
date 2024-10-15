using System.Text.RegularExpressions;
using System.Threading.Tasks.Sources;

namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string name)
        {
            bool isGameOn = true;
            
            do
            {
                Console.Clear();

                int totalScore = Helpers.TotalScore();
                if (totalScore > 0)
                {
                    Console.WriteLine($"Your global score is: {totalScore}");
                }

                var date = DateTime.Now;

                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine($"Hello {name}. It's {date}. Welcome to the Maths game!");

                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                V - View Previous Games
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q - Quit the program");
                Console.WriteLine("-------------------------------------------------------------------");

                var gameSelected = Console.ReadLine().Trim().ToUpper();

                /// This needs some insight and proper placing. When using 'continue', the code runs again and Clears the console.
                /// As a result, the "Invalid input" isn't properly displayed.

                if (!Regex.IsMatch(gameSelected, "[V|A|S|M|D|Q]"))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                Console.WriteLine($"Choose a difficulty level:\n- easy\n- medium\n- hard");
                string input = Console.ReadLine().Trim().ToUpper();
                Difficulty difficultyLevel = new Difficulty();

                switch (input)
                {
                    case "EASY":
                        difficultyLevel = Difficulty.Easy;
                        break;
                    case "MEDIUM":
                        difficultyLevel = Difficulty.Medium;
                        break;
                    case "HARD":
                        difficultyLevel = Difficulty.Hard;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }

                switch (gameSelected)
                {
                    case "V":
                        Helpers.GamesHistory("Game's history:");
                        break;
                    case "A":
                        engine.AdditionGame("Addition game", difficultyLevel);
                        break;
                    case "S":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "M":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "D":
                        engine.DivisionGame("Division game");
                        break;
                    case "Q":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Goodbye");
                        Console.ResetColor();
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}

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

                switch (gameSelected)
                {
                    case "V":
                        Helpers.GamesHistory("Game's history:");
                        break;
                    case "A":
                        engine.AdditionGame("Addition game");
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

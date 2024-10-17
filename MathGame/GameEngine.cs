using System.Diagnostics;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message, Difficulty difficultyLevel, GameType gameType)
        {
            int[] numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);        // generates random numbers based on difficulty level

            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            Stopwatch timer = Stopwatch.StartNew();     // starts the timer

            for (int i = 0; i < 5; i++)     // runs the game 5 times
            {
                Console.Write($"{numbers[0]} + {numbers[1]} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == numbers[0] + numbers[1])        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
                    numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong answer!");
                    Console.ResetColor();
                    numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
                }

                if (i == 4)
                {
                    timer.Stop();
                    Console.WriteLine($"Game over. Your final score is {score}\nPress ANY key to go to the main menu.");
                    Console.WriteLine($"Time elapsed: {Helpers.GameDuration(timer)}");
                    Console.ReadKey();
                }

            }
            Helpers.AddToHistory(score, GameType.Addition);        // possible because of static.

        }
        internal void SubtractionGame(string message, Difficulty difficultyLevel, GameType gameType)
        {
            // generates numbers based on difficulty
            int[] numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;


            for (int i = 0; i < 5; i++)     // runs the game 5 times
            {

                Console.Write($"{numbers[0]} - {numbers[1]} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == numbers[0] - numbers[1])        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
                    // rolls different numbers
                    numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong answer!");
                    Console.ResetColor();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}\nPress ANY key to go to the main menu.");
                    Console.ReadKey();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void MultiplicationGame(string message, Difficulty difficultyLevel, GameType gameType)
        {
            int[] numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            for (int i = 0; i < 5; i++)     // runs the game 5 times
            {
                Console.Write($"{numbers[0]} * {numbers[1]} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == numbers[0] * numbers[1])        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
                    // rolls different numbers
                    numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong answer!");
                    Console.ResetColor();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}\nPress ANY key to go to the main menu.");
                    Console.ReadKey();
                }

            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }
        internal void DivisionGame(string message, Difficulty difficultyLevel, GameType gameType)
        {
            int[] numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
            Console.Clear();
            Console.WriteLine(message);

            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{numbers[0]} : {numbers[1]}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == numbers[0] / numbers[1])        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
                    // rolls different numbers
                    numbers = Helpers.GetDifficultyNumbers(difficultyLevel, gameType);
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong answer!");
                    Console.ResetColor();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}\nPress ANY key to go to the main menu.");
                    Console.ReadKey();
                }
            }
            Helpers.AddToHistory(score, GameType.Division);

        }
    }
}

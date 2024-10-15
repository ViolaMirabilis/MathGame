namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)     // runs the game 5 times
            {
                firstNumber = random.Next(1, 50);
                secondNumber = random.Next(1, 50);

                Console.Write($"{firstNumber} + {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
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

            Helpers.AddToHistory(score, GameType.Addition);        // possible because of static.

        }
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)     // runs the game 5 times
            {
                firstNumber = random.Next(1, 50);
                secondNumber = random.Next(1, 50);

                Console.Write($"{firstNumber} - {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
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
        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)     // runs the game 5 times
            {
                firstNumber = random.Next(1, 5);
                secondNumber = random.Next(1, 15);

                Console.Write($"{firstNumber} * {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
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
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();     // holds the int array returned by the method
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} : {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)        // if successfully parsed var to int AND it is equal to the sum
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
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

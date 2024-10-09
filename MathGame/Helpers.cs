using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MathGame
{
    internal class Helpers
    {
        // all static so they can be accessed by Helpers. instead of Helpers helper = new Helpers(); helper.GamesHistory, etc.

        static List<Game> games = new List<Game>()     // list of a "Game" type so we can store the same datatype in it
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        internal static void GamesHistory(string message)
        {
            // it loops through the list and evaluates each record to see if it matches the expression. If it is, it becomes an object of the new list.
            //var gamesToPrint = games.Where(x => x.Type == GameType.Division);
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 10, 20));       // we compare already set dates to a new DateTime object [which holds a new date proposed by me]
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 10, 20) && x.Score > 3);        // more complex. a given date + a given score
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 10, 20)).OrderByDescending(x => x.Score);       // sorts by descending score
            var gamesToPrint = games.OrderByDescending(x => x.Score);

            Console.Clear();
            if (games.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No games have been played!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------");
                foreach (var game in gamesToPrint)     // runs through the games List
                {
                    Console.WriteLine($"- Date: {game.Date} | Game: {game.Type} | Score: {game.Score}");
                }
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("Press ANY game to go back to the main menu!");
            Console.ReadKey();
        }
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            // we add a whole new "game" object to the list (so one entry stores date, score and game type)
            games.Add(new Game { Date = DateTime.Now, Score = gameScore, Type = gameType});
            // this refers to the Game.cs class
        }
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];        // two element array [number1, number2]

            while (firstNumber % secondNumber != 0)     // assigns new number until the result is an integer
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            // it breaks out of the loop if the result is an integer and assigns the values!
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;      // result is an array of 2 integers
        }
        internal static int TotalScore()
        {
            int score = 0;
            foreach (Game point in games)
            {
                score += point.Score;
            }

            return score;  
        }

    }
}

namespace MathGame;

internal class Game
{
    /* private int _score;
    public int Score
    {
        get { return _score; }      // returns value
        set { _score = value; }     // assigns value. We can add logic here. In autoproperties - we can't;

    } */

    public int Score { get; set; } // exactly the same as above, but we can't have logic here
    public DateTime Date { get; set; }
    public GameType Type { get; set; }
}

internal enum GameType
{
    Addition = 1,
    Subtraction,
    Multiplication,
    Division
}

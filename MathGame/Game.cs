namespace MathGame
{
    internal class Game
    {
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public DateTime Date { get; set; }
        public GameType GameType { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
}

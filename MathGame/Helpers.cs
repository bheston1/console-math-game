namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> previousGames = new List<Game>();

        internal static void AddGameToHistory(GameType gameType, int score, int maxScore)
        {
            previousGames.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                MaxScore = maxScore,
                GameType = gameType,
            });
        }

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 101);
            int secondNumber = random.Next(1, 101);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 101);
                secondNumber = random.Next(1, 101);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void ViewPreviousGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            foreach (Game game in previousGames)
            {
                Console.WriteLine($"{game.Date.ToString("dddd, MMMM dd, yyyy")} - {game.GameType} | Score: {game.Score}/{game.MaxScore}");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press enter to return to menu");
            PressEnter();
        }

        internal static void PressEnter()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.Write("Invalid input\nAnswer: ");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string GetName()
        {
            Console.Write("Please type your name: ");

            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.Clear();
                Console.Write("Name can't be empty\nPlease type your name: ");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}

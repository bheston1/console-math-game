namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();

        internal void ShowMenu(string name)
        {
            bool isGameRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("MATH GAME");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Hello, {name.ToUpper()}. Today is {DateTime.Now.ToString("dddd, MMMM dd, yyyy")}.\n");
                Console.WriteLine($@"Make a selection from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - View previously played games this session
Q - Close program");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition\n------------------------");
                        break;

                    case "s":
                        gameEngine.SubtractionGame("Subtraction\n------------------------");
                        break;

                    case "m":
                        gameEngine.MultiplicationGame("Multiplication\n------------------------");
                        break;

                    case "d":
                        gameEngine.DivisionGame("Division\n------------------------");
                        break;

                    case "v":
                        Helpers.ViewPreviousGames();
                        break;

                    case "q":
                        Environment.Exit(1);
                        break;

                    default:
                        ShowMenu(name);
                        break;
                }
            } while (isGameRunning);
        }

    }
}

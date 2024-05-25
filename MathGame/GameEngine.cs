namespace MathGame
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            int score = 0;
            int maxScore = 5;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct! Press enter to continue");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to continue");
                    Helpers.PressEnter();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Finished. Final score: {score}/{maxScore}.\nPress enter to return to menu");
                    Helpers.PressEnter();
                }
            }

            Helpers.AddGameToHistory(GameType.Division, score, maxScore);
        }

        internal void MultiplicationGame(string message)
        {
            Random random = new Random();
            int score = 0;
            int maxScore = 5;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 11);
                secondNumber = random.Next(1, 11);
                Console.WriteLine($"{firstNumber} x {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct! Press enter to continue");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to continue");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Finished. Final score: {score}/{maxScore}.\nPress enter to return to menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddGameToHistory(GameType.Multiplication, score, maxScore);
        }

        internal void SubtractionGame(string message)
        {
            Random random = new Random();
            int score = 0;
            int maxScore = 5;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(50, 101);
                secondNumber = random.Next(1, 51);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct! Press enter to continue");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to continue");
                    Helpers.PressEnter();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Finished. Final score: {score}/{maxScore}.\nPress enter to return to menu");
                    Helpers.PressEnter();
                }
            }

            Helpers.AddGameToHistory(GameType.Subtraction, score, maxScore);
        }

        internal void AdditionGame(string message)
        {
            Random random = new Random();
            int score = 0;
            int maxScore = 5;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 101);
                secondNumber = random.Next(1, 101);
                Console.Write($"{firstNumber} + {secondNumber}\nAnswer: ");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct! Press enter to continue");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to continue");
                    Helpers.PressEnter();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Finished. Final score: {score}/{maxScore}.\nPress enter to return to menu");
                    Helpers.PressEnter();
                }
            }

            Helpers.AddGameToHistory(GameType.Addition, score, maxScore);
        }
    }
}

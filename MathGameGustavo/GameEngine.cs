using MathGameGustavo.Models;
namespace MathGameGustavo
{
    internal class GameEngine
    {
        Helpers helpers = new Helpers();

        internal void AdditionGame(string message)  
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);
                Console.WriteLine($"{firstNumber} + {secondNumber} ?");
                int result = firstNumber + secondNumber;
                string answer = Console.ReadLine();
                answer = helpers.ValidateAnswer(answer);

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect, The answer was {result}!\n");
                }
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"The game has ended.\nYour final score is {score}!\n");
            helpers.AddToHistory(score, GameType.Addition);
            Console.ReadLine();
        }

        internal void SubtractionGame(string message)   
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);
                Console.WriteLine($"{firstNumber} - {secondNumber} ?");
                int result = firstNumber - secondNumber;
                string answer = Console.ReadLine();
                answer = helpers.ValidateAnswer(answer);

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect, The answer was {result}!\n");
                }
            }
            helpers.AddToHistory(score, GameType.Subtraction);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"The game has ended.\nYour final score is {score}!\n");

            Console.ReadLine();
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);
                Console.WriteLine($"{firstNumber} X {secondNumber} ?");
                int result = firstNumber * secondNumber;
                string answer = Console.ReadLine();
                answer = helpers.ValidateAnswer(answer);

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect, The answer was {result}!\n");
                }
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"The game has ended.\nYour final score is {score}!\n");
            helpers.AddToHistory(score, GameType.Multiplication);
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int[] divisionNumbers = helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];
                Console.WriteLine($"{firstNumber} / {secondNumber}");
                int result = firstNumber / secondNumber;
                string answer = Console.ReadLine();
                answer = helpers.ValidateAnswer(answer);

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect, The answer was {result}!\n");
                }
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"The game has ended.\nYour final score is {score}!\n");
            helpers.AddToHistory(score, GameType.Division);
            Console.ReadLine();
        }
    }
}

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

            string difficultyLevel = helpers.DifficultyMenu();
            string numberOfQuestions = helpers.QuestionNumber();

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                int[] difficulty = helpers.DifficultyNumberGen(difficultyLevel);
                firstNumber = difficulty[0];
                secondNumber = difficulty[1];

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
            helpers.AddToHistory(score, GameType.Addition, int.Parse(numberOfQuestions));
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

            string difficultyLevel = helpers.DifficultyMenu();
            string numberOfQuestions = helpers.QuestionNumber();

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                int[] difficulty = helpers.DifficultyNumberGen(difficultyLevel);
                firstNumber = difficulty[0];
                secondNumber = difficulty[1];

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
            helpers.AddToHistory(score, GameType.Subtraction, int.Parse(numberOfQuestions));
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

            string difficultyLevel = helpers.DifficultyMenu();
            string numberOfQuestions = helpers.QuestionNumber();

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                int[] difficulty = helpers.DifficultyNumberGen(difficultyLevel);
                firstNumber = difficulty[0];
                secondNumber = difficulty[1];

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
            helpers.AddToHistory(score, GameType.Multiplication, int.Parse(numberOfQuestions));
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            int score = 0;
            string numberOfQuestions = helpers.QuestionNumber();

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
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
            helpers.AddToHistory(score, GameType.Division, int.Parse(numberOfQuestions));
            Console.ReadLine();
        }
    }
}

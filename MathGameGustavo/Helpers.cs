using MathGameGustavo.Models;

namespace MathGameGustavo
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>()
        {
            /* Game Examples for Linq
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
            */
        };

        internal int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            /*
            foreach(int number in result)
            {
                Console.WriteLine(number);   
            }
            */

            return result;
        }

        internal void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game{
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
            });
            //games.Add($"{DateTime.Now.ToShortDateString()}\n{DateTime.Now.ToShortTimeString()}\n{gameType}\nScore:{gameScore}");
        }

        internal void PrintGames()
        {
            IEnumerable<Game> gamesToPrint = games.OrderByDescending(x => x.Score);


            Console.Clear();
            Console.WriteLine("Game History:\n---------------------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date.ToShortDateString()}\n{game.Type}\nScore: {game.Score}");
                Console.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }

        internal string? ValidateAnswer(string answer)
        {
            while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                answer = Console.ReadLine();
            }
            return answer;
        }

        internal string GetName()
        {
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cant be empty.");
                name = Console.ReadLine();
            }

            return name;
        }

    }
}

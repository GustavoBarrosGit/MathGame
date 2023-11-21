namespace MathGameGustavo
{
    internal class Menu
    {
        Helpers helpers = new Helpers();
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {


            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Hello, {name}, today is {date}.\n");
                Console.WriteLine(@$"Select what game you want to play:
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        V - View Previous Games
        Q - Quit game");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "v":
                        helpers.PrintGames();
                        break;
                    case "q":
                        Console.WriteLine("Quitting game");
                        isGameOn = false;
                        break;
                    default:
                        break;
                }
            } while (isGameOn);



        }
    }
}

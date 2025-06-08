using MathGame_Niasua.Models;

namespace MathGame_Niasua;
internal class Helpers
{
    internal static List<Game> games = new();
    internal static string GetName()
    {
        Console.Write("Please type your name: ");
        string name = Console.ReadLine();
        return name;
    }
    internal static int[] GetDivisionNumbers()
    {
        Random Random = new Random();
        int firstNumber = Random.Next(0, 99);
        int secondNumber = Random.Next(0, 99);

        int[] result = new int[2];

        // the division must result in an integer
        // the second number must be != 0 and greater than the first number
        while (firstNumber % secondNumber != 0 && secondNumber == 0 && secondNumber > firstNumber)
        {
            firstNumber = Random.Next(0, 99);
            secondNumber = Random.Next(0, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }
    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("------------------------------------------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}");
        }
        Console.WriteLine("------------------------------------------------------\n");
        Console.WriteLine("Press any key to go back to the menu");
        Console.ReadLine();
    }
    internal static void AddToHistory(int score, string game)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = score,
            Type = game
        });
    }
}


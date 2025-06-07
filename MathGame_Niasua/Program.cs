using System;

string name = GetName();
DateTime date = DateTime.UtcNow;

Menu(name);

string GetName()
{
    Console.Write("Please type your name: ");
    string name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. ");
    Console.WriteLine("\n");
    Console.WriteLine(@$"What game would you like to play? Choose from the options below: 
    A - Addition
    S - Substraction
    M - Multiplication
    D - Division
    Q - Quit the program");
    Console.WriteLine("------------------------------------------------------");

    string gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubstractionGame("Substraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}
void DivisionGame(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        int[] nums = GetDivisionNumbers();
        int firstNumber = nums[0];
        int secondNumber = nums[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }

}
void MultiplicationGame(string message)
{
    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}
void SubstractionGame(string message)
{
    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}
void AdditionGame(string message)
{
    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

int[] GetDivisionNumbers()
{
    Random Random = new Random();
    int firstNumber = Random.Next(0, 99);
    int secondNumber = Random.Next(0, 99);

    int[] result = new int[2];

    // the division must result in an integer
    while(firstNumber % secondNumber != 0)
    {
        firstNumber = Random.Next(0, 99);
        secondNumber = Random.Next(0, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}
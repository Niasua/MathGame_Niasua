string name = GetName();
DateTime date = DateTime
    .UtcNow;

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
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void SubstractionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
        }

        if(i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

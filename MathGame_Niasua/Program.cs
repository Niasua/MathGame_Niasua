Console.Write("Please type your name: ");
string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

Menu(name, date);

void Menu(string name, DateTime date)
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
}

void SubstractionGame(string message)
{
    Console.WriteLine(message);
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}

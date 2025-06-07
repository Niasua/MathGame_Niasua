Console.Write("Please type your name: ");
string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

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

if(gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("Substraction game selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid input");
}
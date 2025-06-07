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

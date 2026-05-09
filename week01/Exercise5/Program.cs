using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        Console.WriteLine($"Hello, {name}!");
        int favoriteNumber = PromptUserNumber();
        Console.WriteLine($"Your favorite number is {favoriteNumber}!");
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(squaredNumber, name);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string numberString  = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(int squaredNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}!");
    }

    
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Tima", "Basics of Programming");
        System.Console.WriteLine(assignment1.GetSummary());
        MathAssignment assignment2 = new MathAssignment("Roberto Valenzuela", "Fractions", "7.3", "3-10, 20-21");
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment2.GetSummary());
        System.Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment3.GetSummary());
        System.Console.WriteLine(assignment3.GetWritingInformation());
    }
}
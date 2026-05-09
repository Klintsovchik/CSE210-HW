using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write series of numbers and stop with a 0: ");
        string numbers = Console.ReadLine();
        List<int> numberList = new List<int>();
        while (numbers != "0")
        {
            int number = int.Parse(numbers);
            numberList.Add(number);
            Console.Write("Write series of numbers and stop with a 0: ");
            numbers = Console.ReadLine();
        }
        int sum = 0;
        foreach (int number in numberList)        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = sum / numberList.Count;
        Console.WriteLine($"The average of the numbers is: {average:F2}");
        int max = numberList[0];
        foreach (int number in numberList)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");
        int minPositive = int.MaxValue;
        foreach (int number in numberList)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers.");
        }
        else
        {
            Console.WriteLine($"The minimum positive number is: {minPositive}");
        }
        numberList.Sort();
        Console.WriteLine("The numbers in sorted order are:");
        foreach (int number in numberList)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}
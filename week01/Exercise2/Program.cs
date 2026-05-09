using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);
        string letterGrade;
        
            if (gradePercentage >= 90)
            {
                letterGrade = "A";
            }
            else if (gradePercentage >= 80)
            {
                letterGrade = "B";
            }
            else if (gradePercentage >= 70)
            {
                letterGrade ="C";
            }
            else if (gradePercentage >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            int lastDigit = gradePercentage % 10;
            string sign;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            if (letterGrade != "F")
            {
                letterGrade += sign;
            }
            if (letterGrade == "A" && sign == "+")
            {
                letterGrade = "A";
            }
            Console.WriteLine($"Your letter grade is {letterGrade}");
            
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }
            else
            {
                Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
            }
        }
        
        
    }
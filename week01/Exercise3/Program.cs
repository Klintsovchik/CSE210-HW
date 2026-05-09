using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Console.Write("Give the magical number: ");
            string magicalNumber = Console.ReadLine();
            int magicalNumberInt = int.Parse(magicalNumber);
            int guessCount = 0;
            int guessInt = -1;

            while (guessInt != magicalNumberInt)
            {
                Console.Write("Guess the magical number: ");
                string guess = Console.ReadLine();
                guessInt = int.Parse(guess);
                guessCount++;
                if (guessInt < magicalNumberInt)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guessInt > magicalNumberInt)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}
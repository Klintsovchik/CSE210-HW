using System;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("lds-scriptures.txt");
        Random random = new Random();
        string randomLine = lines[random.Next(0, lines.Length)];
        string[] parts = randomLine.Split("     ");
        string referenceText = parts[0];
        string scriptureText = parts[1];
        Reference reference = Reference.ParseFromString(referenceText);
        Scripture scripture = new Scripture(reference, scriptureText);

        while(true)
        {
            Console.Clear();
            System.Console.WriteLine(scripture.GetDisplayText());
            System.Console.WriteLine("Press enter to continue or type 'quit'  to exit");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                System.Console.WriteLine("Come back later");
                break;
            }
            else if(scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords();
            }
        }
    }

}
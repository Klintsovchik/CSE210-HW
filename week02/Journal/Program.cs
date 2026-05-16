using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        while(true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Take a new note");
            Console.WriteLine("2. Show all notes");
            Console.WriteLine("3. Save to the file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            string filename = "";
            switch(choice)
            {
                case "1":
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string response = Console.ReadLine();
                Entry entry = new Entry(DateTime.Now, prompt, response);
                journal.AddEntry(entry);
                break;
                case "2":
                journal.DisplayAll();
                break;
                case "3":
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.SaveToFile(filename);
                break;
                case "4":
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                break;
                case "5":
                Environment.Exit(0);
                break;
            }
                
        }

    }
}
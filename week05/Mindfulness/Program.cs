class Program
{
    static void Main(string[] args)
    {
        // This boolean controls the lifecycle of the main application menu loop 
        bool keepRunning = true;

        while (keepRunning)
        {
            // Clears the console window for a clean and professional user interface presentation
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Captures the user's input from the console
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case "3":;
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
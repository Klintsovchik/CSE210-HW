public class ListingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(0, _prompts.Count);
        string prompt = _prompts[index];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;

        System.Console.WriteLine(prompt);

        while (DateTime.Now < endTime)
        {
            System.Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        System.Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }
}

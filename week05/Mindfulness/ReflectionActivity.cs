public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity() : base ("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience...")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        System.Console.WriteLine(prompt);
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            System.Console.WriteLine();
            int questionIndex = random.Next(0, _questions.Count);
            string question = _questions[questionIndex];
            System.Console.WriteLine(question);
            ShowSpinner(5);
        }
        DisplayEndingMessage();


    }

}
public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;
    public PromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>()
        {
            "What was the best part of your day?",
            "How would you describe your day in 1 sentence?",
            "Who you talked to today?",
            "What is one thing you learned from today?",
            "What was the most tiring?",
            "Best part?",
            
        };
    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];   
    }

}
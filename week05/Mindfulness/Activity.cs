public class Activity
{
    // Protected attributes: accessible within this class and its derived classes
    protected string _name = "";
    protected string _description ="";
    protected int _duration = 0;

    // List of characters used to create the loading/spinner animation
    protected List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

    // Constructor to initialize common attributes for all activities
    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        System.Console.WriteLine(_name);
        System.Console.WriteLine(_description);
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        System.Console.WriteLine("Get ready");
    }
    public void DisplayEndingMessage()
    {
        System.Console.WriteLine("Well done!!");
        ShowSpinner(3);
        System.Console.WriteLine($"you have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }
    // Generates a spinning animation for a specific number of seconds
    public void ShowSpinner(int spin)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spin);
        int i = 0;

        // Loop runs until the specified amount of seconds has passed
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            System.Console.Write(s);
            Thread.Sleep(250);
            System.Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0; //go back to the first symbol
            }
        }
    }
    
    // Displays a numeric countdown timer (e.g., 5... 4... 3...)
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            System.Console.Write(i);
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
        }
    }
}
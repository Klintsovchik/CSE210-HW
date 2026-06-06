public class Activity
{
    protected string _name = "";
    protected string _description ="";
    protected int _duration = 0;
    protected List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

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
    public void ShowSpinner(int spin)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spin);
        int i = 0;
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
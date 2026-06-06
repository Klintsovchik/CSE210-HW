
// Inherits from the base Activity class
public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {

    }
    public void Run()
    {
        // start with start message
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop repeats the breathing cycle until the overall duration is reached
        while (DateTime.Now < endTime)
        {
            System.Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Clear();
            System.Console.Write("Breath out...");
            ShowCountDown(4);
            Console.Clear();
        }
        DisplayEndingMessage();
    }
}
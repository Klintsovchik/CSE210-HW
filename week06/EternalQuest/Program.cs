using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }
    public void ListGoalDetails()
    {
        System.Console.WriteLine("The goals are: ");
        
        for (int i =0; i < _goals.Count; i++)
        {
            System.Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        System.Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();
        System.Console.Write("What is a short description of it?");
        string description = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if(goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            System.Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());
            System.Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(target, bonus, name, description, points));
        }
    }
    public void RecordEvent()
    {
        System.Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            // We use the getter that we implemented in the Goal base class
            System.Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        System.Console.WriteLine("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to return to 0-based indices

        int pointsEarned = _goals[goalIndex].RecordEvent();
        _score += pointsEarned;
        System.Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        System.Console.WriteLine($"Your new score is: {_score}");
    }

    public void SaveGoal()
    {
        System.Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // The first line stores the total points
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        System.Console.WriteLine("Goals saved successfully!");
    }
    public void loadGoals()
{
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found!");
        return;
    }

    _goals.Clear(); // Clear the list before loading


    string[] lines = System.IO.File.ReadAllLines(filename);


    _score = int.Parse(lines[0]);


    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        
        // Cut the string by commas, like in your template!
        string[] parts = line.Split(",");

        string goalType = parts[0];

        if (goalType == "SimpleGoal")
        {
            // parts[1] - name, parts[2] - description, parts[3] - points
            SimpleGoal simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
            
            // If the file says True, then the goal was completed
            if (parts[4] == "True")
            {
                // We need to mark it as completed. To do this, we can call recordEvent
                simple.RecordEvent(); 
            }
            _goals.Add(simple);
        }
        else if (goalType == "EternalGoal")
        {
            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (goalType == "ChecklistGoal")
        {
            // The checklist order is: name (1), description (2), points (3), bonus (4), target (5), amountCompleted (6)
            int points = int.Parse(parts[3]);
            int bonus = int.Parse(parts[4]);
            int target = int.Parse(parts[5]);
            int amountCompleted = int.Parse(parts[6]);

            ChecklistGoal checklist = new ChecklistGoal(target, bonus, parts[1], parts[2], points);
            
            // Restore how many times the goal was already completed last time
            for (int count = 0; count < amountCompleted; count++)
            {
                checklist.RecordEvent();
            }

            _goals.Add(checklist);
        }
    }
    Console.WriteLine("Goals loaded successfully!");
}

    public void Start()
    {
        string userOptions = "";
        while (userOptions != "6")
        {
            System.Console.WriteLine($"You have {_score} points");
            System.Console.WriteLine("1. Create New Goal");
            System.Console.WriteLine("2. List Goals");
            System.Console.WriteLine("3. Save Goals");
            System.Console.WriteLine("4. Load Goals");
            System.Console.WriteLine("5. Record Event");
            System.Console.WriteLine("6. Quit");
            System.Console.WriteLine("Select your choice from the menu: ");
            userOptions = Console.ReadLine();

            if (userOptions == "1")
            {
                CreateGoal();
            }
            else if (userOptions == "2")
            {
                ListGoalDetails();
            }
            else if (userOptions =="3")
            {
                SaveGoal();
            }
            else if(userOptions =="4")
            {
                loadGoals();
            }
            else if (userOptions == "5")
            {
                RecordEvent();
            }
        }

    }


    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
        
    }
}
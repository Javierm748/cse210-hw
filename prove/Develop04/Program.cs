using System;

public abstract class MindfulnessActivity
{
    protected int Duration { get; set; }

    public void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName} Activity");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(5);
    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine($"Good job! You have completed the {activityName} activity.");
        Console.WriteLine($"You spent {Duration} seconds on this activity.");
        PauseWithAnimation(5);
    }

    public void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity();
}
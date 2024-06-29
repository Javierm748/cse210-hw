using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        EternalQuestProgram program = new EternalQuestProgram();

        // Example: Adding goals
        program.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        program.AddGoal(new EternalGoal("Read Scriptures", 100));
        program.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));

        // Example: Recording events
        program.RecordEvent(0); // Completes "Run a Marathon"
        program.RecordEvent(1); // Records reading scriptures
        program.RecordEvent(2); // Records attending temple

        // Example: Display goals, score, and level
        program.DisplayGoals();
        program.DisplayScore();

        // Additional functionalities can be added here

        Console.ReadLine(); // Keeps console window open
    }
}

public class EternalQuestProgram
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private int level = 1;
    private int nextLevelThreshold = 1000; // Example threshold for leveling up

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.MarkComplete();
            score += goal.Points;

            // Check if level up condition is met
            if (score >= nextLevelThreshold)
            {
                LevelUp();
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private void LevelUp()
    {
        level++;
        nextLevelThreshold += 1000; // Increase threshold for next level
        Console.WriteLine($"Congratulations! You've reached Level {level}!");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].Progress()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Next Level Threshold: {nextLevelThreshold} points");
    }
}


// what did I do to exceed the requirements? I added a feature that I labeled leveling up.
//Leveling System: The EternalQuestProgram class now includes a leveling system that tracks the user's progress based on their score. Whenever an event is recorded (using RecordEvent method), the program checks if the user's score meets or surpasses the nextLevelThreshold. If it does, the LevelUp method is triggered, which increases the user's level and adjusts the next level threshold accordingly.
//Display: The DisplayScore method has been updated to provide more feedback to the user. It now shows not only the current score but also the user's current level and the score threshold needed to reach the next level. This feature encourages users to achieve more goals in order to progress through the levels and potentially unlock new rewards or features.
//This enhancement adds a gamified aspect to your program, motivating users to complete goals and earn points to advance to higher levels. It can make the experience more engaging and rewarding for users as they work towards achieving their personal goals within the Eternal Quest program.
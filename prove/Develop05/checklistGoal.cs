
// Checklist goal that requires a specific number of completions for bonus points
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int points, int targetCount)
    {
        Name = name;
        Points = points;
        this.targetCount = targetCount;
    }

    public override void MarkComplete()
    {
        currentCount++;
        if (currentCount == targetCount)
        {
            Points += 500; // Bonus points on completion
            IsCompleted = true;
        }
    }

    public override string Progress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}

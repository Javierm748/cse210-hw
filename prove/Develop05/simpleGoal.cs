
// Simple goal that can be marked complete for fixed points
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void MarkComplete()
    {
        IsCompleted = true;
    }

    public override string Progress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}


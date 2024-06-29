// Eternal goal that accumulates points each time it's recorded
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void MarkComplete()
    {
        // Eternal goal is never marked fully complete
    }

    public override string Progress()
    {
        return "[X]";
    }
}

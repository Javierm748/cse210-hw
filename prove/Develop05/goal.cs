// Base class for goals
public abstract class Goal
{
    public string Name { get; set; }
    public bool IsCompleted { get; protected set; }
    public int Points { get; protected set; }

    public abstract void MarkComplete();
    public abstract string Progress();
}

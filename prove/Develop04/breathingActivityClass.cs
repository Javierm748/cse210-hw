using System;

public class BreathingActivity : MindfulnessActivity
{
    public override void PerformActivity()
    {
        StartMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        for (int i = 0; i < Duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);
        }
        EndMessage("Breathing");
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through slow, deep breaths. Clear your mind and focus on your breathing.";
    }

    protected override void DoActivity()
    {
        int interval = 4;
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountdown(interval);

            Console.Write("Breathe out...");
            ShowCountdown(interval);

            elapsed += interval * 2;
        }
    }
}
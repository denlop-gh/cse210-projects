public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
    
        Console.Write("Enter duration in seconds: ");
        string input = Console.ReadLine();
        int duration;
        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }
        _duration = duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DoActivity();

        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected abstract void DoActivity();

    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\rLoading... " + i);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
        
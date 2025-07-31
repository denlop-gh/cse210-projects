public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List three things you are grateful for today.",
        "Write down five goals you want to achieve this week.",
        "Name four people who inspire you and why.",
        "Identify three habits you want to develop or improve."
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you organize your thoughts and focus on positive aspects of your life. Take a moment to list down your thoughts.";
    }

    protected override void DoActivity()
    {
        Random rand = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        ShowCountdown(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        Console.WriteLine("You have completed the listing activity!");
    }
}
    

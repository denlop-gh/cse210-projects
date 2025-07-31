public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you felt proud of yourself. What did you do?",
        "Reflect on a challenge you overcame. How did it make you feel?",
        "Consider a moment when you felt truly happy. What contributed to that happiness?",
        "Recall a time when you learned something new. How did it change your perspective?"
    };
    private List<string> _questions = new List<string>()
    {
        "What did you learn from this experience?",
        "How can you apply this lesson in the future?",
        "What emotions did you feel during this experience?",
        "How has this experience shaped who you are today?",
        "What would you do differently if you faced a similar situation again?",
        "What strengths did you discover in yourself through this experience?",
        "How can you use this reflection to improve your future actions?",
        "What insights did you gain about yourself?",
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on your thoughts and feelings. Take a moment to think deeply about the prompts provided.";
    }

    protected override void DoActivity()
    {
        Random rand = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions and write down your responses:");
        ShowSpinner(3);

        int elapsed = 0;
        int interval = 10;

        while (elapsed < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"> {question} ");
            ShowSpinner(interval);
            elapsed += interval;
        }
    }
}
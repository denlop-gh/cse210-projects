using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you eat today?",
        "What are you grateful for?",
        "What challenges did you face today?",
        "What made you smile today?",
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"¡Goal '{_shortName}' recorded! You have won {_points} points.");
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}
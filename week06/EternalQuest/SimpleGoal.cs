public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"¡Goal done! You have won {_points} points.");
            return _points;

        }
        else
        {
            Console.WriteLine("Esta meta ya fue completada.");
            return 0; 
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{(_isComplete ? "1" : "0")}";
    }
}
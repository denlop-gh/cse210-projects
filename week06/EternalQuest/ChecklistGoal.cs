public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"¡Goal '{_shortName}' updated! You have completed {_amountCompleted}/{_target} and earned {_points} points.");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"¡Goal '{_shortName}' completed! You have earned a bonus of {_bonus} points.");
                return _points += _bonus;
            }
            else
            {
                return _points;
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0; 
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
using System.Diagnostics.Metrics;

public class Swimming : Activity
{
    private int laps;
    private const double LapLenghtMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * LapLenghtMeters) * MetersToMiles;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({Minutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile, Laps: {laps}";
    }
}
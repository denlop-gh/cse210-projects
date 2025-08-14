using System;

class Program
{
    static void Main(string[] args)
    {

        Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2022, 11, 4), 45, 15.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 5), 60, 40);


        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}

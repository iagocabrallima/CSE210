using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> activities = new List<Exercise>();
        activities.Add(new Running("05 Apr 2023", 60, 8.7));
        activities.Add(new Cycling("06 Apr 2023", 35, 15.2));
        activities.Add(new Swimming("07 Apr 2023", 45, 35));

        foreach (Exercise exercise in activities)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
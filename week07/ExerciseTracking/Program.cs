using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2026, 6, 10), 30, 5.0),
            new Cycling(new DateTime(2026, 6, 11), 45, 20.0),
            new Swimming(new DateTime(2026, 6, 12), 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

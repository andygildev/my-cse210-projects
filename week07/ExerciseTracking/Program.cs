using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Activity run = new Running("03 Nov 2022", 30, 3.0);
        Activity bike = new Cycling("03 Nov 2022", 45, 12.0);
        Activity swim = new Swimming("03 Nov 2022", 60, 40);

        List<Activity> activities = new List<Activity> { run, bike, swim };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

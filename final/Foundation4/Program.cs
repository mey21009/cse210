using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("12 Feb 2024",8.7,25));
        activities.Add(new CyclingActivity("13 Jan 2020",10.6,25));
        activities.Add(new Swimming("20 Sept 2023",90,25));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY No{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}
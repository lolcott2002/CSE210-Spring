public class Program
{
    public static void Main(string[] args)
    {
        //holds each activity in a list
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2024, 12, 04), 30, 3.0));
        activities.Add(new Running(new DateTime(2025, 01, 11), 45, 5.2));
        activities.Add(new Cycling(new DateTime(2025, 02, 15), 60, 15.0));
        activities.Add(new Cycling(new DateTime(2025, 03, 17), 90, 18.5));
        activities.Add(new Swimming(new DateTime(2025, 04, 06), 20, 40));
        activities.Add(new Swimming(new DateTime(2025, 07, 05), 30, 60));

        Console.WriteLine("Here are the activities you have completed:\n");
        //displays the list
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetWorkoutSummary());
        }
        //lets the user exit
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
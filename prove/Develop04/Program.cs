using System;

public class Program
{
    public static void Main(string[] args)
    {
        //let the user choose which activity they would like to do
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine(" thanks for choosing my mindfulness app. I hope it helps.");
            Console.WriteLine(" choose one of the following activities (type the number):");
            Console.WriteLine("  1. breathing ");
            Console.WriteLine("  2. reflection");
            Console.WriteLine("  3. listing");
            Console.WriteLine("  4. end program");
            choice = Console.ReadLine();

            Activity currentActivity = null;
            if (choice == "1")
            {
                currentActivity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                currentActivity = new ReflectionActivity();
            }
            else if (choice == "3")
            {
                currentActivity = new ListingActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("thanks for trying it out. have a good one.");
            }
            else
            {
                Console.WriteLine("I didn't understand what you typed.");
                Thread.Sleep(1500);
            }
            if (currentActivity != null)
            {
                currentActivity.RunActivity();
            }
        }
    }
}

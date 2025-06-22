public class ListingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "what generally makes you happy?",
        "what'something you have done well this week?",
        "how have you helped someone else this week?",
        "how have you sought to be a better person today?",
        "how has someone else helped you this week?",
    };
    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "this can help to remember how you have been blessed or how you have blessed others recently.")
    {
    }
    public override void RunActivity()
    {
        //this selects a random prompt and lets the user respond to it for a specified amount of time
        ShowStartingMessage();
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n you can answer as many time as you can for the following prompt:");
        Console.WriteLine($"{prompt}");
        Console.Write("start when the timer ends (you can always type done to leave)");
        ShowCountdown(5);
        Console.WriteLine();
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_lengthOfTime);

        Console.WriteLine("go!");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item) || item.ToLower() == "done")
            {
                break;
            }
            items.Add(item);
        }
        Console.WriteLine($"\n nice! you wrote down {items.Count} things.");
        ShowEndingMessage();
    }
}

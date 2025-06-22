public class ReflectionActivity : Activity
{
    //create 2 lists of prompts and follow-up questions
    private List<string> _prompts = new List<string>
    {
        "when was the last time you helped a family member?",
        "when was the last time you helped a friend?",
        "when was the last time you helped a stranger?",
        "when was the last time you left your comfort zone to serve someone?"
    };

    private List<string> _questions = new List<string>
    {
        "what did you gain from that experience?",
        "What did you learn from that experience?",
        "how did you feel after that experience?",
        "how do you feel now thinking about that experience?",
        "how will you seek for more experiences like that one?",
        "how can you apply what you learned from that experience to your life now?",
        "how can you prepare yourself for similar experiences in the future?",
        "how did that experience effect your discipleship?",
        "how did that experience help you to grow spiritually?",
    };

    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity", "this can help you to reflect on your life and how you can improve it.")
    {
        _lengthOfTime = 45;
    }
    public override void RunActivity()
    {
        //this selects a random prompt and lets the user respond to it
        ShowStartingMessage();
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\nhere is your prompt:\n\n--- {prompt} ---");
        Console.WriteLine("\nwhen  you're ready to answer, go ahead and high enter.");
        Console.ReadLine();
        Console.WriteLine("now think about the following:");
        ShowCountdown(5);
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _lengthOfTime)
        {
            //this shows a random follow-up question
            string question = _questions[_random.Next(_questions.Count)];
            Console.Write($"\n> {question} ");
            DisplaySpinner(5); 
        }

        ShowEndingMessage();
    }
}
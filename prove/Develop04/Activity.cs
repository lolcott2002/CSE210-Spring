//this is a public abstract class that applies to all activites. I can then create derived classes for each
//activity type.
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _lengthOfTime;

    //make a name and brief description for each activity
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //let the user customize each activity
    protected void ShowStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _lengthOfTime) || _lengthOfTime <= 0)
        {
            Console.Write("you did something I couldn't understand. try again. ");
            input = Console.ReadLine();
        }

        Console.WriteLine("getting your activity started");
        DisplaySpinner(5); 
    }

  //all activities can end the same way
    protected void ShowEndingMessage()
    {
        Console.WriteLine("\nnice work, you've finished it");
        DisplaySpinner(3);
    }
    protected void DisplaySpinner(int seconds)
    //this should make a little spinner that looks like a loading circle
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        int i = 0;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(200);
            Console.Write("\b \b"); 
            i = (i + 1) % spinnerChars.Count;
        }
    }

    // this should show the user a simple countdown
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i); 
            Thread.Sleep(1000); 
            Console.Write(new string('\b', i.ToString().Length) + new string(' ', i.ToString().Length) + new string('\b', i.ToString().Length));
        }
    }
    public abstract void RunActivity();
}

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "this walks you through a breathing exercise. my wife is pregnant so its extra practice for me")
    {
    }

    public override void RunActivity()
    {
        ShowStartingMessage();

        Console.WriteLine("\nokay lets get started");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _lengthOfTime)
        {
            // Breathe in
            Console.Write("breath in with the countdown:");
            ShowCountdown(4);
            Console.Write("\r           \r"); //this should clear the console

            // make sure the countdown is done
            if ((DateTime.Now - startTime).TotalSeconds >= _lengthOfTime)
            {
                break;
            }

            // Breathe out
            Console.Write("breath out with the countdown:");
            ShowCountdown(5);
            Console.Write("\r            \r");
        }

        ShowEndingMessage();
    }
}


using System;
public class Program
{
    static void Main(string[] args)
    {
        //creation of object for my favorite scipture
        ScriptureReference alma365ref = new ScriptureReference("Alma", 36, 5);
        Scripture alma365 = new Scripture(alma365ref, "Now, behold, I say unto you, if I had not been born of God I should not have known these things; but God has, by the mouth of his holy angel, made these things known unto me, not of any worthiness of myself;");

        // set it as the current scripture
        Scripture myScripture = alma365;

        while (!myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(myScripture.TextToDisplay());
            Console.WriteLine("\ngo ahead and hit enter to hide more words. you can also type 'quit' if you want.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            //makes sure 2 words are hidden each time
            else if (string.IsNullOrEmpty(userInput))
            {
                myScripture.HideRandomWords(2);
            }
        }
        Console.Clear();
        Console.WriteLine(myScripture.TextToDisplay());
        Console.WriteLine("\ncongrats you did it!");
    }
}
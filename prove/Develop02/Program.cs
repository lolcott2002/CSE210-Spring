public class MainProgram
{
    public static void Main(string[] args)
{
    string filename = "journal.txt"; 
    Journal myJournal = new Journal(filename);
    myJournal.LoadEntriesFromFile();

    PromptGenerator promptGenerator = new PromptGenerator();
    string randomPrompt;
    Entry currentEntry;
    string userInput;

        do
        {
            Console.WriteLine("\nChoose what you want to do:");
            Console.WriteLine("1. Write a new jounral entry");
            Console.WriteLine("2. Read old entries");
            Console.WriteLine("3. Cancel");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                randomPrompt = promptGenerator.GetRandomPrompt();
                currentEntry = new Entry(randomPrompt);
                Console.WriteLine($"Date: {currentEntry.GetCreationDate()}"); 
                Console.WriteLine($"\nToday's Prompt:\n{currentEntry.GetPrompt()}\n");
                Console.WriteLine("(hit enter when you're done writing)");
                currentEntry.SetUserEntry(Console.ReadLine());
                myJournal.AddEntry(currentEntry);
                myJournal.SaveEntriesToFile();
            }
            else if (userInput == "2")
            {
                myJournal.DisplayAllEntries();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("And it came to pass when Alma had heard these words he wrote them down that he might have them- Mosiah 26:33. Don't forget to Journal again tomorrow!");
            }
            else
            {
                Console.WriteLine("I didn't understand that input.");
            }
        } while (userInput != "3");
    }
}
//classes: journal, entry, prompt generator
//prompt generaotr: genrate a prompt
//entry: hold data and display it
//journal: add and display entries, save them to a file, load from a file
//journal should read and write a file
//entry data type should have a date, prompt, and response, all with different data types
//prompt generator should have a list of prompts
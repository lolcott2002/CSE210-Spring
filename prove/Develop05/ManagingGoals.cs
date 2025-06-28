//this class is most of how the user interacts with the program.
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
// this is the start up menu that will greet the user
    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("  1. create a new goal to start working on");
            Console.WriteLine("  2. give a list of goals");
            Console.WriteLine("  3. report that you finshed a goal");
            Console.WriteLine("  4. save all goals");
            Console.WriteLine("  5. load all goals");
            Console.WriteLine("  6. close program");
            Console.Write("(please type in the corresponding number to the choice you want) ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MakeGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordGoal();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    Console.WriteLine("thanks for working on goals today.");
                    break;
                default:
                    Console.WriteLine("I didn;t understand something that you did. start again.");
                    break;
            }
            Console.WriteLine();
        }
    }
// let them check their progress
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\ncurrently you have a total of {_score} points.");
    }
//let them check their goals
    public void ListGoals()
    {
        Console.WriteLine("\nhere are your goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("your goals are empty at this time. go make some!");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }
//let them make a new goal
    public void MakeGoal()
    {
        Console.WriteLine("here are you options:");
        Console.WriteLine("  1. simple goal");
        Console.WriteLine("  2. eternal (spiritual) goal");
        Console.WriteLine("  3. checklist-type goal");
        Console.Write("type the number of the goal you want to create: ");
        string goalType = Console.ReadLine();

        Console.Write("give your goal a name to find it later:  ");
        string name = Console.ReadLine();

        Console.Write("give it a short description:  ");
        string description = Console.ReadLine();

        Console.Write("How many points are you going to give it? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Bonus points can be given if you accomplish this a certain amount of times. How many do you want to set it for? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("If you reach that goal, how many bonus points do you want to give it? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Try again. I don't understand what you typed. ");
                break;
        }
        Console.WriteLine("All done!");
    }
//let them record something they did towards a goal
    public void RecordGoal()
    {
        Console.WriteLine("\nhere are your goals:");
        ListGoals();

        if (_goals.Count == 0)
        {
            return;
        }

        Console.Write("which goal did you accomplish? (type the number) ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            int pointsGained = goal.RecordGoal();
            _score += pointsGained;
        }
        else
        {
            Console.WriteLine("I didn;t understand that. try again.");
        }
    }
//let them save goals to a file
    public void SaveGoals()
    {
        Console.Write("type the filename you want your goals saved to: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"your goals have been saved to '{filename}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"looks like something went wrong. Heres the message: {ex.Message}");
        }
    }
//let them load goals from a file they previously saved them to
    public void LoadGoals()
    {
        Console.Write("give me the filename for your goal file: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"you gave me this: '{filename}' and I couldn't find a file of that name.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] goalData = parts[1].Split(',');

                string name = goalData[0];
                string description = goalData[1];
                int points = int.Parse(goalData[2]);

                switch (goalType)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(goalData[3]);
                        _goals.Add(new SimpleGoal(name, description, points, isComplete));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        int targetAmount = int.Parse(goalData[3]);
                        int bonusPoints = int.Parse(goalData[4]);
                        int amountCompleted = int.Parse(goalData[5]);
                        _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonusPoints, amountCompleted));
                        break;
                    default:
                        Console.WriteLine($"I didn't understand '{goalType}'");
                        break;
                }
            }
            Console.WriteLine($"Here's the goals from '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"something went wrong. this is the code: {ex.Message}");
        }
    }
}

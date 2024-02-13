public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;
    // public GoalManager(List<Goal> goals, int score)
    // {
    //     _goals = goals;
    //     _score = score;
    // }
    public void Start()
    {
        bool menu = true;
        Console.WriteLine("Welcome!");

        while(menu)
        {
            Console.Clear();
            Console.Write(@$"You currently have {_score} points.
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
");
        int menuChoice = int.Parse(Console.ReadLine());
        switch(menuChoice)
        {
            case 1:
                CreateGoal();
                break;

            case 2:
                ListGoalNames();
                Console.Write(@"Press any key to exit.
");
                Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("What is the name of the file? ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
                break;

            case 4:
                Console.WriteLine("What is the name of the file? ");
                filename = Console.ReadLine();
                LoadGoals(filename);
                break;

            case 5:
                RecordEvent();
                break;

            case 6:
                menu = false;
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }
    public void ListGoalNames()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void ListGoalDetails()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.Write(@"The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
What type of goal would you like to create? ");

            int goalChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            switch(goalChoice)
            {
                case 1:
                    SimpleGoal simpleGoal = new(false, name, description, points);
                    _goals.Add(simpleGoal);
                    break;
                case 2:
                    EternalGoal eternalGoal = new (name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case 3:
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new(target, bonus, name, description, points);
                    _goals.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? (Input the corresponding index)");
        ListGoalNames();
        
        Console.Write("");
        int accomplishedGoal = int.Parse(Console.ReadLine());
        _goals[accomplishedGoal].RecordEvent();

        // Updates the total score
        _score += int.Parse(_goals[accomplishedGoal]._points); 

    }
    public void SaveGoals(string filename)
    {
        using StreamWriter outputFile = new(filename);
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('-');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(bool.Parse(parts[4]), parts[1], parts[2], parts[3]));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(int.Parse(parts[4]), int.Parse(parts[5]), parts[1], parts[2], parts[3]));
                    break;
                default:
                    Console.WriteLine("Load failed.");
                    break;
            }
        }
    }
}
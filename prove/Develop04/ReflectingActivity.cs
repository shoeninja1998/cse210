public class ReflectingActivity:Activity
{
    private List<string> _questions;
    private List<string> _prompts;
    public ReflectingActivity(List<string> Prompts, List<string> Questions, string Name, string Description, int Duration)
    :base(Name, Description, Duration)
    {
        _questions = Questions;
        _prompts = Prompts;
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int randomIndex = random.Next(0,_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new();
        int randomIndex = random.Next(0,_questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions()
    {
        int duration = _duration;
        while (duration > 0)
        {
            Console.WriteLine(GetRandomQuestion() + " ");
            while(!Console.KeyAvailable)
            {
                ShowSpinner(1);
                duration--;
            }
            Console.ReadKey(true);
        }
    }
}
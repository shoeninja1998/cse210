public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int Count, List<string> Prompts, string Name, string Description, int Duration)
    :base(Name, Description, Duration)
    {
        _count = Count;
        _prompts = Prompts;
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountdown(3);
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (currentTime <= endTime)
        {
            Console.Write("\b\b");
            Console.Write("> ");
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine(_count);
// Creativity
        if(_count > 1)
        {
            Console.WriteLine($"You listed {_count} times!");
        }
        else
        {
            Console.WriteLine("You listed 1 time.");
        }

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new();
        int randomIndex = random.Next(0,_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }
}
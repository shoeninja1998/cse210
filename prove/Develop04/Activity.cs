public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string Name, string Description, int Duration)
    {
        _name = Name;
        _description = Description;
        _duration = Duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(4);
        Console.Clear();

    }
    public void ShowSpinner(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(@"\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write(@"|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write(@"/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write(@"-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            seconds -= 1;
        }
    }
    public void ShowCountdown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds -= 1;
            Console.Write("\b\b");
        }
    }
}
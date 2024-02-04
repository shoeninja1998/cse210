public class BreathingActivity:Activity
{
    public BreathingActivity(string Name, string Description, int Duration)
    :base(Name, Description, Duration){}
    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;

        string breatheMessage = "Breathe in...";
        while(duration > 0)
        {
            Console.WriteLine(breatheMessage);
            int count = 5;
            while(count != 0)
            {
                Console.Write(count);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                count--;
                duration--;
            }
            if(breatheMessage == "Breathe in...")
            {
                breatheMessage = "Now breathe out...";
            }
            else if(breatheMessage == "Now breathe out...")
            {
                breatheMessage = "Breathe in...";
            }
        }

        DisplayEndingMessage();
    }
}
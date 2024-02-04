using System;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        while (active)
        {
            Console.Clear();
            Console.Write(@"Welcome! What would you like to do?
1. Breathing Activity
2. Reflecting Activity
3. Listing Activity
4. Quit
> ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new(
                        "Breathing Activity",
                        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                        0
                    );
                    breathingActivity.ShowSpinner(5);
                    breathingActivity.Run();
                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new(
                        new()
                        {
                            "Think of a time when you stood up for someone else.",
                            "Think of a time when you did something really difficult.",
                            "Think of a time when you helped someone in need.",
                            "Think of a time when you did something truly selfless"
                        },
                        new()
                        {
                            "Why was this experience meaningful to you?",
                            "Have you ever done anything like this before?",
                            "How did you get started?",
                            "How did you feel when it was complete?",
                            "What made this time different than other times when you were not as successful?",
                            "What is your favorite thing about this experience?",
                            "What could you learn from this experience that applies to other situations?",
                            "What did you learn about yourself through this experience?",
                            "How can you keep this experience in mind in the future?"
                        },
                        "Reflecting Activity",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                        0
                    );
                    reflectingActivity.ShowSpinner(5);
                    reflectingActivity.Run();
                    break;

                case 3:
                    ListingActivity listingActivity = new(
                        0,
                        new()
                        {
                            "Who are people that you appreciate?",
                            "What are personal strengths of yours?",
                            "Who are people that you have helped this week?",
                            "When have you felt the Holy Ghost this month?",
                            "Who are some of your personal heroes?"
                        },
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                        0
                    );
                    listingActivity.ShowSpinner(5);
                    listingActivity.Run();
                    break;
                
                case 4:
                    active = false;
                    break;
            }
        }
    }
}
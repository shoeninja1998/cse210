using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new();
        int magicNumber = random.Next(1,100);
        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > magicNumber)
            {
                Console.WriteLine("The magic number is lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("The magic number is higher.");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }
    }
}
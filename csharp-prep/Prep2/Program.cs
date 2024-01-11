using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        double gradePercentage = double.Parse(Console.ReadLine());

        string grade = "";
        string message = "";

        if (gradePercentage >= 90)
        {
            grade = "an A";
        }
        else if (gradePercentage >= 80)
        {
            grade = "a B";
        }
        else if (gradePercentage >= 70)
        {
            grade = "a C";
        }
        if (gradePercentage >= 60)
        {
            grade = "a D";
        }
        else
        {
            grade = "an F";
        }

        if (gradePercentage >= 70)
        {
            message = "Congratulations, you passed!";
        }
        else
        {
            message = "You failed. Try harder next time!";
        }

        Console.WriteLine($"{message} You received {grade}.");
    }
    }
using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numberList = new();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("");
            number = int.Parse(Console.ReadLine());
            numberList.Add(number);
        }

        // foreach (int addedNumber in numberList)
        // {
        //     Console.WriteLine(addedNumber);
        // }

        int numberSum = numberList.Sum();
        double numberAvg = numberList.Average();
        int numberMax = numberList.Max();

        Console.Write(@$"The sum is {numberSum}.
The average is {numberAvg}.
The largest number is {numberMax}.");


    }
}
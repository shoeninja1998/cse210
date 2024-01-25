using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new();
        Fraction f2 = new(7);
        Fraction f3 = new(2, 4);
        Fraction f4 = new(5, 2);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}
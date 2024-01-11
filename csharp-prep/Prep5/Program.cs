using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);
        
        DisplayResult(name, squareNumber);
    }
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int number){
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string name, int squareNumber){
            Console.WriteLine($"{name}, the square of your favorite number is {squareNumber}.");
        }
}
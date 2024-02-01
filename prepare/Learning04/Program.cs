using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Bradley Rennick","Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new("Section 7.6","Problems 8-19","Bradley Rennick","Math");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new("Native American Tribes", "Bradley Rennick", "Tribal Cultures");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
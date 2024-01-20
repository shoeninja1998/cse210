using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        Prompt promptObject = new();
        Journal journalObject = new();

        Console.WriteLine("Welcome! Here are your choices:");

        while(loop){
            Console.Write(@"1. Write a new entry
2. Display the journal
3. Save the journal to a file
4. Load the journal from a file
5. Quit
What would you like to do?
");
        int response = int.Parse(Console.ReadLine());
            switch(response)
            {
                case 1:
                    Entry entryObject = new()
                    {
                        _promptText = $"Prompt: {promptObject.GetRandomPrompt()}"
                    };

                    entryObject.WriteEntry();
                    journalObject.AddEntry(entryObject);
                    break;

                case 2:
                    journalObject.DisplayAll();
                    break;
                
                case 3:
                    Console.Write("What is the name of the file you want to save your journal to? ");
                    string filename = Console.ReadLine();
                    journalObject.SaveToFile(filename);
                    break;

                case 4:
                    Console.Write("What is the name of the file you want to load your journal from? ");
                    filename = Console.ReadLine();
                    journalObject.LoadFromFile(filename);
                    break;

                case 5:
                    loop = false;
                    break;
            }
        }
    }
}
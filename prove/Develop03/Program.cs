using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        Reference reference01 = new("Matthew", 22, 37);
        List<Word> words01 = new(){
            new("This", "This", false),
            new("is", "is", false),
            new("the", "the", false),
            new("first", "first", false),
            new("and", "and", false),
            new("great", "great", false),
            new("commandment.", "commandment.", false)
        };
        Scripture scripture01 = new(words01, reference01);
        while(loop)
        {
// Displays scripture
            Console.WriteLine(scripture01.GetScriptureText());
            Console.Write("");
            Console.ReadLine();
// Checks to see if all words are hidden
            bool completelyHidden = scripture01.DetermineIfCompletelyHidden();
            if (completelyHidden)
            {
                loop = false;
            }
            else
            {
                scripture01.HideRandomWords();
            }
        }
    }
}
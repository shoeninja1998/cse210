using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        Reference reference01 = new("Matthew", 22, 37);
        List<Word> words01 = new(){
            new("This", false),
            new("is", false),
            new("the", false),
            new("first", false),
            new("and", false),
            new("great", false),
            new("commandment.", false)
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
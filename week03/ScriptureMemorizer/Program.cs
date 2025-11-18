using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Psalm", 18, 2);

        string verseText = "The LORD is my rock, my fortress and my deliverer; my God is my rock, " +
                           "in whom I take refuge, my shield and the horn of my salvation, my stronghold.";

        Scripture scripture = new Scripture(reference, verseText);

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("\nPress Enter to hide words or type 'quit' to exit. ");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3); 
            }
        }
    }
}

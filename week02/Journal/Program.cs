class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator PromptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save as (e.g., journal.txt): ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load from: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
        }

        Console.WriteLine("\nGoodbye!");
    }
}
using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an activity: ");

                string choice = Console.ReadLine();
                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => null
                };

                if (activity != null)
                {
                    activity.Run();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }
    }
}

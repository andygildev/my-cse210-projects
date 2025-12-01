using System;
using System.Threading;

namespace MindfulnessProgram
{
    abstract class Activity
    {
        protected string Name;
        protected string Description;
        protected int Duration;

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void SetDuration()
        {
            Console.Write("Enter duration of activity in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
            {
                Console.Write("Please enter a valid positive number: ");
            }
        }

        protected void StartMessage()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Name} Activity!");
            Console.WriteLine(Description);
            SetDuration();
            Console.WriteLine("Prepare to begin...");
            PauseWithAnimation(3);
        }

        protected void EndMessage()
        {
            Console.WriteLine($"\nGreat job! You completed {Name} for {Duration} seconds.");
            PauseWithAnimation(3);
        }

        protected void PauseWithAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}

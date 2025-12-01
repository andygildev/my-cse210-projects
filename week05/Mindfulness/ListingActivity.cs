using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        public override void Run()
        {
            StartMessage();
            Random rand = new Random();
            Console.WriteLine(prompts[rand.Next(prompts.Count)]);
            Console.WriteLine("Start listing items. Press Enter after each one:");
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            int count = 0;

            while (DateTime.Now < endTime)
            {
                if (!string.IsNullOrEmpty(Console.ReadLine()))
                {
                    count++;
                }
            }

            Console.WriteLine($"You listed {count} items!");
            EndMessage();
        }
    }
}

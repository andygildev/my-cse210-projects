using System;

namespace MindfulnessProgram
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        { }

        public override void Run()
        {
            StartMessage();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                PauseWithAnimation(4);
                Console.WriteLine("Breathe out...");
                PauseWithAnimation(4);
            }
            EndMessage();
        }
    }
}

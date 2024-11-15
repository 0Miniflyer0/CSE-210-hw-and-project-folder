using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public override void RunActivity()
        {
            StartActivity("Breathing Activity", 
                "This activity will help you relax by guiding your breathing.");

            for (int i = 0; i < _duration; i += 2)
            {
                Console.WriteLine("Breathe in...");
                DisplaySpinner(2);
                Console.WriteLine("Breathe out...");
                DisplaySpinner(2);
            }

            EndActivity("Breathing Activity");
        }
    }
}

using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int _duration;  

        public void StartActivity(string activityName, string description)
        {
            Console.WriteLine($"{activityName} - {description}");
            Console.Write("Enter duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready to begin...");
            DisplaySpinner(3);
        }

        public void EndActivity(string activityName)
        {
            Console.WriteLine("Good job! You've completed the activity.");
            DisplaySpinner(3);
            Console.WriteLine($"{activityName} finished in {_duration} seconds.");
        }

        protected void DisplaySpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("...");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void RunActivity();
    }
}

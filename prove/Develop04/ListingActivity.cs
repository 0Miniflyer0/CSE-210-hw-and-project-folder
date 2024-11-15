using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };

        public override void RunActivity()
        {
            StartActivity("Listing Activity", 
                "This activity will help you reflect on good things by listing them.");

            Random rand = new Random();
            Console.WriteLine(prompts[rand.Next(prompts.Count)]);
            DisplaySpinner(3);

            int count = 0;
            DateTime startTime = DateTime.Now;  
            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                Console.Write("List an item: ");
                Console.ReadLine();
                count++;
            }

            Console.WriteLine($"You listed {count} items.");
            EndActivity("Listing Activity");
        }
    }
}

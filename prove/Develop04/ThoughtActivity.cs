using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ThoughtActivity : MindfulnessActivity
    {
        private List<string> categories = new List<string>
        {
            "Food", "Furniture", "School", "Family"
        };

        public override void RunActivity()
        {
            StartActivity("Thought Activity", 
                "This activity will prompt you with a category. Write down the first thing that comes to mind.");

            Random rand = new Random();
            int count = 0;
            DateTime startTime = DateTime.Now;  

            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                string category = categories[rand.Next(categories.Count)];
                Console.Write($"Think of the first thing that comes to mind for '{category}': ");
                Console.ReadLine();
                count++;
                DisplaySpinner(2);  
            }
            Console.WriteLine($"You entered {count} thoughts during the activity.");
            EndActivity("Thought Activity");
        }
    }
}

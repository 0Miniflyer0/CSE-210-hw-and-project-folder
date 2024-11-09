using System;
using System.Collections.Generic;
using System.Threading;


// The classes 
namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int duration;
        
        public void StartActivity(string activityName, string description)
        {
            Console.WriteLine($"{activityName} - {description}");
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready to begin...");
            DisplaySpinner(3); 
        }

        public void EndActivity(string activityName)
        {
            Console.WriteLine("Good job! You've completed the activity.");
            DisplaySpinner(3); 
            Console.WriteLine($"{activityName} finished in {duration} seconds.");
        }

        protected void DisplaySpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void RunActivity();
    }

    // Breathing Activity (REQ 1)
    public class BreathingActivity : MindfulnessActivity
    {
        public override void RunActivity()
        {
            StartActivity("Breathing Activity", 
                "This activity will help you relax by guiding your breathing.");

            for (int i = 0; i < duration; i += 2)
            {
                Console.WriteLine("Breathe in...");
                DisplaySpinner(2);
                Console.WriteLine("Breathe out...");
                DisplaySpinner(2);
            }

            EndActivity("Breathing Activity");
        }
    }

    // Reflection Activity (REQ 2)
    public class ReflectionActivity : MindfulnessActivity
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What could you learn from this experience?"
        };

        public override void RunActivity()
        {
            StartActivity("Reflection Activity", 
                "This activity will help you reflect on times in your life when you showed strength.");

            Random rand = new Random();
            Console.WriteLine(prompts[rand.Next(prompts.Count)]);
            DisplaySpinner(3);

            for (int i = 0; i < duration; i += 5)
            {
                Console.WriteLine(questions[rand.Next(questions.Count)]);
                DisplaySpinner(5);
            }

            EndActivity("Reflection Activity");
        }
    }

    // Listing Activity (REQ 3)
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
            var startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                Console.Write("List an item: ");
                Console.ReadLine();
                count++;
            }

            Console.WriteLine($"You listed {count} items.");
            EndActivity("Listing Activity");
        }
    }

    // Thought Activity, idk where i was going with this activity so i just made something for the creavitiy part
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
            var startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < duration)
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

    // Main Program (Had a tutor help me with this.)
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program\nChoose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Thought Activity"); 
                Console.WriteLine("5. Exit");
                Console.Write("Selection: ");

                string choice = Console.ReadLine();
                MindfulnessActivity activity;

                switch (choice)
                 { 
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        activity = new ThoughtActivity();  // Cases are the activiivities so case 1-5 are the acitivites, 5th is the exit/finish
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }

                activity.RunActivity();
            }
        }
    }
}


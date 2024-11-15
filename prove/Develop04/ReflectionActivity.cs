using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
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

            for (int i = 0; i < _duration; i += 5)
            {
                Console.WriteLine(questions[rand.Next(questions.Count)]);
                DisplaySpinner(5);
            }
            EndActivity("Reflection Activity");
        }
    }
}

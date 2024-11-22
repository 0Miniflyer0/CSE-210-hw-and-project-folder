using System;

public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add a New Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.CreateNewGoal();
                    break;

                case "2":
                    Console.Write("Enter the name of the goal you accomplished: ");
                    string goalName = Console.ReadLine();
                    manager.RecordEvent(goalName);
                    break;

                case "3":
                    manager.DisplayGoals();
                    break;

                case "4":
                    Console.WriteLine($"Your current score is: {manager.GetScore()} points");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                _score += goal.GetPoints();

                // Oo bonus points
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetPoints();
                }
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (Goal goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.Write($"{status} {goal.GetName()}: {goal.GetDescription()}");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($" (Completed {checklistGoal.GetCurrentCount()}/{checklistGoal.GetTargetCount()} times)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("Select goal type to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter points for completing this goal: ");
                int simplePoints = int.Parse(Console.ReadLine());
                AddGoal(new SimpleGoal(name, description, simplePoints));
                break;

            case "2":
                Console.Write("Enter points for each time this goal is recorded: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                AddGoal(new EternalGoal(name, description, eternalPoints));
                break;

            case "3":
                Console.Write("Enter points for each step of the goal: ");
                int stepPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of times this goal must be completed: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing this goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                AddGoal(new ChecklistGoal(name, description, stepPoints, targetCount, bonusPoints));
                break;

            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }
}

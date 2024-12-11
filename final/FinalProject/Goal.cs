using System;

public class Goal
{
    private string goalDescription;
    private DateTime startDate;
    private DateTime endDate;
    private int goalTarget;

    public Goal(string description, DateTime start, DateTime end, int target)
    {
        goalDescription = description;
        startDate = start;
        endDate = end;
        goalTarget = target;
    }

    public void DisplayGoal()
    {
        Console.WriteLine($"Goal: {goalDescription}");
        Console.WriteLine($"Target: {goalTarget} workouts");
        Console.WriteLine($"Start Date: {startDate.ToShortDateString()}");
        Console.WriteLine($"End Date: {endDate.ToShortDateString()}");
    }

    public void UpdateGoal(string newDescription, DateTime newStartDate, DateTime newEndDate, int newTarget)
    {
        goalDescription = newDescription;
        startDate = newStartDate;
        endDate = newEndDate;
        goalTarget = newTarget;
        
        Console.WriteLine("Goal updated.");
    }
}

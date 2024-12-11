using System;

public class Workout
{
    private string workoutType;
    private DateTime date;
    private int duration; // minutes
    private int caloriesBurned;

    public Workout(string type, DateTime workoutDate, int workoutDuration, int calories)
    {
        workoutType = type;
        date = workoutDate;
        duration = workoutDuration;
        caloriesBurned = calories;
    }

    public virtual void InputWorkoutDetails()
    {
        Console.WriteLine("Enter the workout type:");
        workoutType = Console.ReadLine();

        Console.WriteLine("Enter the workout duration (in minutes):");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the calories burned:");
        caloriesBurned = int.Parse(Console.ReadLine());

        date = DateTime.Now; // Automatically set the current date
    }

    public virtual void DisplayWorkoutDetails()
    {
        Console.WriteLine($"Workout Type: {workoutType}");
        Console.WriteLine($"Date: {date.ToShortDateString()}");
        Console.WriteLine($"Duration: {duration} minutes");
        Console.WriteLine($"Calories Burned: {caloriesBurned}");
    }

    public DateTime GetWorkoutDate()
    {
        return date;
    }
}

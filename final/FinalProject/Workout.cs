using System;

public class Workout
{
    private string workout_name;
    private DateTime workout_date;
    private int duration_minutes;
    private int calories_burned;

    public Workout(string name, DateTime date, int duration, int calories)
    {
        workout_name = name;
        workout_date = date;
        duration_minutes = duration;
        calories_burned = calories;
    }
    public virtual void InputWorkoutDetails()
    {
        Console.WriteLine("Enter the workout name:");
        workout_name = Console.ReadLine();

        Console.WriteLine("Enter the workout duration (in minutes):");
        duration_minutes = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the calories burned:");
        calories_burned = int.Parse(Console.ReadLine());

        workout_date = DateTime.Now; 
    }

    public virtual void DisplayWorkoutDetails()
    {
        Console.WriteLine("Workout Name: " + workout_name);
        Console.WriteLine("Date: " + workout_date.ToShortDateString());
        Console.WriteLine("Duration: " + duration_minutes + " minutes");
        Console.WriteLine("Calories Burned: " + calories_burned);
    }
}

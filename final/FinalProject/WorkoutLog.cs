using System;
using System.Collections.Generic;
using System.Linq;

public class WorkoutLog
{
    private List<Workout> workoutList;

    public WorkoutLog()
    {
        workoutList = new List<Workout>();
    }

    public void AddWorkout(Workout workout)
    {
        workoutList.Add(workout);
        Console.WriteLine("Workout added to the log.");
    }

    public void DisplayAllWorkouts()
    {
        Console.WriteLine("\nWorkout Log:");
        foreach (var workout in workoutList)
        {
            workout.DisplayWorkoutDetails();
            Console.WriteLine();
        }
    }

    public void DisplayWorkoutsByType(string type)
    {
        var filteredWorkouts = workoutList.Where(w => w.GetType().Name == type);
        Console.WriteLine($"\n{type} Workouts:");
        foreach (var workout in filteredWorkouts)
        {
            workout.DisplayWorkoutDetails();
            Console.WriteLine();
        }
    }

    public void DisplayWorkoutsByDate(DateTime date)
    {
        var filteredWorkouts = workoutList.Where(w => w.GetWorkoutDate().Date == date.Date);
        Console.WriteLine($"\nWorkouts on {date.ToShortDateString()}:");
        foreach (var workout in filteredWorkouts)
        {
            workout.DisplayWorkoutDetails();
            Console.WriteLine();
        }
    }
}

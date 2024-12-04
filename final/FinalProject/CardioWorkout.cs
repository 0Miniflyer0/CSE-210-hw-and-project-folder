using System;

public class CardioWorkout : Workout
{
    private double distance_miles;
    private double average_pace;

    public CardioWorkout(string name, DateTime date, int duration, int calories, double distance, double pace)
        : base(name, date, duration, calories)
    {
        distance_miles = distance;
        average_pace = pace;
    }

    public override void DisplayWorkoutDetails()
    {
        base.DisplayWorkoutDetails();
        Console.WriteLine("Distance: " + distance_miles + " miles");
        Console.WriteLine("Average Pace: " + average_pace + " min/mile");
    }
}

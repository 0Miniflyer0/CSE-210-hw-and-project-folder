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

    public override void InputWorkoutDetails()
    {
        base.InputWorkoutDetails();

        Console.WriteLine("Enter the distance (in miles):");
        distance_miles = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the average pace (in minutes per mile):");
        average_pace = double.Parse(Console.ReadLine());
    }

    public override void DisplayWorkoutDetails()
    {
        base.DisplayWorkoutDetails();
        Console.WriteLine("Distance: " + distance_miles + " miles");
        Console.WriteLine("Average Pace: " + average_pace + " min/mile");
    }
}

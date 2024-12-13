using System;

public class CardioWorkout : Workout
{
    private double distanceMiles;
    private double averagePace;

    public CardioWorkout(string workoutType, DateTime date, int duration, int calories, double distance, double pace)
        : base(workoutType, date, duration, calories)
    {
        distanceMiles = distance;
        averagePace = pace;
    }

    public override void InputWorkoutDetails()
    {
        base.InputWorkoutDetails();

        Console.WriteLine("Enter the distance (in miles):");
        distanceMiles = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the average pace (in minutes per mile):");
        averagePace = double.Parse(Console.ReadLine());
    }

    public override void DisplayWorkoutDetails()
    {
        base.DisplayWorkoutDetails();
        Console.WriteLine("Distance: " + distanceMiles + " miles");
        Console.WriteLine("Average Pace: " + averagePace + " min/mile");
    }
}

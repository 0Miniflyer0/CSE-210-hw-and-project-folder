using System;

public class StrengthWorkout : Workout
{
    private int weight_lifted;
    private int repetitions;
    private int sets;

    public StrengthWorkout(string name, DateTime date, int duration, int calories, int weight, int reps, int sets_count)
        : base(name, date, duration, calories)
    {
        weight_lifted = weight;
        repetitions = reps;
        sets = sets_count;
    }

    public override void DisplayWorkoutDetails()
    {
        base.DisplayWorkoutDetails();
        Console.WriteLine("Weight Lifted: " + weight_lifted + " lbs");
        Console.WriteLine("Repetitions: " + repetitions);
        Console.WriteLine("Sets: " + sets);
    }
}

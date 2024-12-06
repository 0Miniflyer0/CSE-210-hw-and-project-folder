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

    public override void InputWorkoutDetails()
    {
        base.InputWorkoutDetails();

        Console.WriteLine("Enter the weight lifted (in lbs):");
        weight_lifted = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of repetitions:");
        repetitions = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of sets:");
        sets = int.Parse(Console.ReadLine());
    }

    public override void DisplayWorkoutDetails()
    {
        base.DisplayWorkoutDetails();
        Console.WriteLine("Weight Lifted: " + weight_lifted + " lbs");
        Console.WriteLine("Repetitions: " + repetitions);
        Console.WriteLine("Sets: " + sets);
    }
}

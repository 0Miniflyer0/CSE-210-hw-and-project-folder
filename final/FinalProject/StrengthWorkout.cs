using System;

public class StrengthWorkout : Workout
{
    private int weightLifted;
    private int repetitions;
    private int sets;

    public StrengthWorkout(string workoutType, DateTime date, int duration, int calories, int weight, int reps, int sets_count)
        : base(workoutType, date, duration, calories)
    {
        weightLifted = weight;
        repetitions = reps;
        sets = sets_count;
    }

    public override void InputWorkoutDetails()
    {
        base.InputWorkoutDetails();

        Console.WriteLine("Enter the weight lifted (in lbs):");
        weightLifted = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of repetitions:");
        repetitions = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of sets:");
        sets = int.Parse(Console.ReadLine());
    }

    public override void DisplayWorkoutDetails()
    {
        base.DisplayWorkoutDetails();
        Console.WriteLine("Weight Lifted: " + weightLifted + " lbs");
        Console.WriteLine("Repetitions: " + repetitions);
        Console.WriteLine("Sets: " + sets);
    }
}

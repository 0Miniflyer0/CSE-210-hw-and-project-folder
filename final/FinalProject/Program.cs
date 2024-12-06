using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Workout> workoutList = new List<Workout>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Fitness Tracker!");
            Console.WriteLine("Choose a workout type to log:");
            Console.WriteLine("1. General Workout");
            Console.WriteLine("2. Cardio Workout");
            Console.WriteLine("3. Strength Workout");
            Console.WriteLine("4. Display All Workouts");
            Console.WriteLine("5. Exit");
            // 12/6 2024, only 3 classes are done.
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Workout generalWorkout = new Workout("", DateTime.Now, 0, 0);
                    generalWorkout.InputWorkoutDetails();
                    workoutList.Add(generalWorkout);
                    break;

                case "2":
                    CardioWorkout cardio = new CardioWorkout("", DateTime.Now, 0, 0, 0.0, 0.0);
                    cardio.InputWorkoutDetails();
                    workoutList.Add(cardio);
                    break;

                case "3":
                    StrengthWorkout strength = new StrengthWorkout("", DateTime.Now, 0, 0, 0, 0, 0);
                    strength.InputWorkoutDetails();
                    workoutList.Add(strength);
                    break;

                case "4":
                    Console.WriteLine("\nLogged Workouts:");
                    foreach (var workout in workoutList)
                    {
                        workout.DisplayWorkoutDetails();
                        Console.WriteLine();
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting the Fitness Tracker. Stay fit!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

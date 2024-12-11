using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Workout> workoutList = new List<Workout>();


        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        int userAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your fitness level (Beginner/Intermediate/Advanced): ");
        string fitnessLevel = Console.ReadLine();


        User user = new User(userName, userAge, fitnessLevel);
        Notification notification = new Notification("Remember To Log Your Workout.", userName);


        Console.WriteLine("Enter trainer's name: ");
        string trainerName = Console.ReadLine();

        Console.WriteLine("Enter trainer's expertise area: ");
        string expertiseArea = Console.ReadLine();
        Trainer trainer = new Trainer(trainerName, expertiseArea);

        Console.WriteLine("Enter your goal name: ");
        string goalName = Console.ReadLine();

        Console.WriteLine("Enter your goal target (number of workouts): ");
        int goalTarget = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal start date (yyyy-mm-dd): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal end date (yyyy-mm-dd): ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        Goal goal = new Goal(goalName, startDate, endDate, goalTarget);

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to the Fitness Tracker!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Log a General Workout");
            Console.WriteLine("2. Log a Cardio Workout");
            Console.WriteLine("3. Log a Strength Workout");
            Console.WriteLine("4. Display All Workouts");
            Console.WriteLine("5. Update User Details");
            Console.WriteLine("6. Display User Details");
            Console.WriteLine("7. Display Notification");
            Console.WriteLine("8. Update Notification Message");
            Console.WriteLine("9. Change Notification Recipient");
            Console.WriteLine("10. Display Trainer Information");
            Console.WriteLine("11. Update Trainer Information");
            Console.WriteLine("12. Display Goal");
            Console.WriteLine("13. Update Goal");
            Console.WriteLine("14. Exit");

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
                    user.UpdateUserDetails();
                    break;

                case "6":
                    user.DisplayUserDetails();
                    break;

                case "7":
                    notification.DisplayNotification();
                    break;

                case "8":
                    Console.WriteLine("Enter the new notification message:");
                    string newMessage = Console.ReadLine();
                    notification.UpdateMessage(newMessage);
                    break;

                case "9":
                    Console.WriteLine("Enter the new notification recipient name:");
                    string newRecipient = Console.ReadLine();
                    notification.SetRecipient(newRecipient);
                    break;

                case "10":
                    trainer.DisplayTrainerInfo();
                    break;

                case "11":
                    trainer.UpdateTrainerInfo();
                    break;

                case "12":
                    goal.DisplayGoal();
                    break;

                case "13":
                    Console.WriteLine("Enter the new goal description:");
                    string newGoalDescription = Console.ReadLine();
                    Console.WriteLine("Enter new goal target:");
                    int newGoalTarget = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the new goal start date (yyyy-mm-dd):");
                    DateTime newStartDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the new goal end date (yyyy-mm-dd):");
                    DateTime newEndDate = DateTime.Parse(Console.ReadLine());
                    goal.UpdateGoal(newGoalDescription, newStartDate, newEndDate, newGoalTarget);
                    break;

                case "14":
                    running = false;
                    Console.WriteLine("Exiting the Fitness Tracker. Stay fit!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}

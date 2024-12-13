using System;

public class User
{
    private string userName;
    private int userAge;
    private string fitnessLevel;

    public User(string name, int age, string level)
    {
        userName = name;
        userAge = age;
        fitnessLevel = level;
    }

    public void UpdateUserDetails()
    {
        Console.WriteLine("Update User Details:");
        Console.Write("Enter new name: ");
        userName = Console.ReadLine();

        Console.Write("Enter new age: ");
        if (int.TryParse(Console.ReadLine(), out int new_age))
        {
            userAge = new_age;
        }
        else
        {
            Console.WriteLine("Invalid age. Keeping the previous value.");
        }

        Console.Write("Enter new fitness level (Beginner/Intermediate/Advanced): ");
        fitnessLevel = Console.ReadLine();
    }

    public void DisplayUserDetails()
    {
        Console.WriteLine("\nUser Details:");
        Console.WriteLine($"Name: {userName}");
        Console.WriteLine($"Age: {userAge}");
        Console.WriteLine($"Fitness Level: {fitnessLevel}");
    }
}

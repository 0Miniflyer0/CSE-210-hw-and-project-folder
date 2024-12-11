using System;

public class User
{
    private string user_name;
    private int user_age;
    private string fitness_level;

    public User(string name, int age, string level)
    {
        user_name = name;
        user_age = age;
        fitness_level = level;
    }

    public void UpdateUserDetails()
    {
        Console.WriteLine("Update User Details:");
        Console.Write("Enter new name: ");
        user_name = Console.ReadLine();

        Console.Write("Enter new age: ");
        if (int.TryParse(Console.ReadLine(), out int new_age))
        {
            user_age = new_age;
        }
        else
        {
            Console.WriteLine("Invalid age. Keeping the previous value.");
        }

        Console.Write("Enter new fitness level (Beginner/Intermediate/Advanced): ");
        fitness_level = Console.ReadLine();
    }

    public void DisplayUserDetails()
    {
        Console.WriteLine("\nUser Details:");
        Console.WriteLine($"Name: {user_name}");
        Console.WriteLine($"Age: {user_age}");
        Console.WriteLine($"Fitness Level: {fitness_level}");
    }
}

using System;

public class Trainer
{
    private string trainerName;
    private string expertiseArea;

    public Trainer(string name, string expertise)
    {
        trainerName = name;
        expertiseArea = expertise;
    }

    public void DisplayTrainerInfo()
    {
        Console.WriteLine($"Trainer: {trainerName}");
        Console.WriteLine($"Expertise Area: {expertiseArea}");
    }

    public void UpdateTrainerInfo()
    {
        Console.WriteLine("Enter new trainer name:");
        trainerName = Console.ReadLine();

        Console.WriteLine("Enter new expertise area:");
        expertiseArea = Console.ReadLine();

        Console.WriteLine("Trainer information updated.");
    }
}

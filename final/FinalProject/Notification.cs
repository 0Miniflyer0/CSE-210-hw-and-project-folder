using System;

public class Notification
{
    private string notification_message;
    private string recipient_name;

    public Notification(string message, string recipient = null)
    {
        notification_message = message;
        recipient_name = recipient;
    }

    public void DisplayNotification()
    {
        Console.WriteLine("\nNotification:");
        if (!string.IsNullOrEmpty(recipient_name))
        {
            Console.WriteLine($"To: {recipient_name}");
        }
        Console.WriteLine($"Message: {notification_message}");
    }

    public void UpdateMessage(string new_message)
    {
        notification_message = new_message;
        Console.WriteLine("Notification message updated.");
    }

    public void SetRecipient(string recipient)
    {
        recipient_name = recipient;
        Console.WriteLine("Recipient updated.");
    }
}

using System;

public class Notification
{
    private string notificationMessage;
    private string recipientName;

    public Notification(string message, string recipient = null)
    {
        notificationMessage = message;
        recipientName = recipient;
    }

    public void DisplayNotification()
    {
        Console.WriteLine("\nNotification:");
        if (!string.IsNullOrEmpty(recipientName))
        {
            Console.WriteLine($"To: {recipientName}");
        }
        Console.WriteLine($"Message: {notificationMessage}");
    }

    public void UpdateMessage(string new_message)
    {
        notificationMessage = new_message;
        Console.WriteLine("Notification message updated.");
    }

    public void SetRecipient(string recipient)
    {
        recipientName = recipient;
        Console.WriteLine("Recipient updated.");
    }
}

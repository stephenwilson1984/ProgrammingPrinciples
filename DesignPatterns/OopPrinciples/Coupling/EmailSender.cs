namespace DesignPatterns.OopPrinciples.Coupling;

public class EmailSender : INotificationService
{
    public void SendNotification(string message)
    {
        // Send email logic
        Console.WriteLine($"Sending email: {message}");
    }
}
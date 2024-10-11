namespace DesignPatterns.OopPrinciples.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        // Send SMS logic
        Console.WriteLine($"Sending SMS: {message}");
    }
}
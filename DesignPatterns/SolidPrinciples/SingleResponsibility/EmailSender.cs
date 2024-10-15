namespace DesignPatterns.SolidPrinciples.SingleResponsibility;

public class EmailSender
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"Sending email to {email} with message: {message}");
    }
}
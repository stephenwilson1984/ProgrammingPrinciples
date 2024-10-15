namespace DesignPatterns.SolidPrinciples.SingleResponsibility;

public class UserService
{
    public void Register(User user)
    {
        // Register user logic

        // Send email
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.Email, "Welcome to our website!");
    }
}
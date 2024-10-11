namespace DesignPatterns.OopPrinciples.Abstraction;

public static class Abstraction
{
    public static void Run()
    {
        // Abstraction is the process of hiding the implementation details of an object and only showing the essential features of the object.
        EmailService emailService = new EmailService();
        emailService.SendEmail();
    }
}
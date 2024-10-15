namespace DesignPatterns.SolidPrinciples.SingleResponsibility;

public static class SingleResponsibilityExample
{
    public static void Run()
    {
        // Single Responsibility Principle
        // A class should have only one reason to change (only one responsibility)
        // If a class has more than one responsibility, it has more than one reason to change

        UserService userService = new UserService();
        userService.Register(new User { Username = "John Doe", Email = "user@user.com" });
    }
}
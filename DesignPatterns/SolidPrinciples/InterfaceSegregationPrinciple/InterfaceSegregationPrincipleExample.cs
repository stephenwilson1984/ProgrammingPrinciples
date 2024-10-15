namespace DesignPatterns.SolidPrinciples.InterfaceSegregationPrinciple;

public static class InterfaceSegregationPrincipleExample
{
    public static void Run()
    {
        // Interface Segregation Principle
        // A client should never be forced to implement an interface that it doesn't use.
        // Instead of having one big interface, we should have multiple smaller interfaces.
        // This way, the client can choose which interface to implement.

        var circle = new Circle();
        circle.Radius = 5;
        Console.WriteLine($"Circle Area: {circle.Area()}");
    }
}
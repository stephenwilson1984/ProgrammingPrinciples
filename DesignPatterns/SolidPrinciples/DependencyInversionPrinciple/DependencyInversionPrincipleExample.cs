namespace DesignPatterns.SolidPrinciples.DependencyInversionPrinciple;

public static class DependencyInversionPrincipleExample
{
    public static void Run()
    {
        // Dependency Inversion Principle
        // The Dependency Inversion Principle states that high-level modules should not depend on low-level modules.
        // Both should depend on abstractions. In addition, abstractions should not depend on details. Details should depend on abstractions.

        // The Car class is a high-level module and the Engine class is a low-level module.
        // The Car class depends on the Engine class. This is a violation of the Dependency Inversion Principle.
        // To fix this, we can introduce an interface IEngine and make the Engine class implement it.
        // Then, we can make the Car class depend on the IEngine interface instead of the Engine class.
        // This way, the Car class depends on an abstraction (IEngine) instead of a detail (Engine).

        var car = new Car(new Engine());
        car.Start();
    }
}
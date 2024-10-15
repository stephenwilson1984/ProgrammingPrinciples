namespace DesignPatterns.OopPrinciples.Composition;

public static class CompositionExample
{
    public static void Run()
    {
        // Composition is a design principle that allows you to build complex objects by combining simpler objects.
        // It is an alternative to inheritance, where a class can inherit from only one superclass.
        Car car = new Car();
        car.StartCar();
    }
}
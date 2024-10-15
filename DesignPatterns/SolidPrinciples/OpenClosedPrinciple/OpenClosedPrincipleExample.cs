namespace DesignPatterns.SolidPrinciples.OpenClosedPrinciple;

public static class OpenClosedPrincipleExample
{
    public static void Run()
    {
        // Open/Closed Principle
        // Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification
        // Once a class is written, it should be closed for modification and open for extension

        var shapes = new List<Shape>
        {
            new Circle { Radius = 5 },
            new Rectangle { Length = 10, Width = 5 }
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetType().Name}: {shape.CalculateArea()}");
        }
    }
}
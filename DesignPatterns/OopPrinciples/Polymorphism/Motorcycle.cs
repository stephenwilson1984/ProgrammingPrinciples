namespace DesignPatterns.OopPrinciples.Polymorphism;

public class Motorcycle : Vehicle
{
    public int NumberOfWheels { get; set; }

    public override void Start()
    {
        Console.WriteLine("Starting motorcycle...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping motorcycle...");
    }
}
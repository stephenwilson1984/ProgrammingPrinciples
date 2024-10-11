namespace DesignPatterns.OopPrinciples.Polymorphism;

public class Plane : Vehicle
{
    public int NumberOfEngines { get; set; }

    public override void Start()
    {
        Console.WriteLine("Starting plane...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping plane...");
    }
}
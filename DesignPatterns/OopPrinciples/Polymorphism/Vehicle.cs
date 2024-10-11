namespace DesignPatterns.OopPrinciples.Polymorphism;

public class Vehicle
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("Starting vehicle...");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Stopping vehicle...");
    }
}
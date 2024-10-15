namespace DesignPatterns.SolidPrinciples.DependencyInversionPrinciple;

public class Car
{
    private readonly IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car started");
    }
}
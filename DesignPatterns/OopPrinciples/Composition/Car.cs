namespace DesignPatterns.OopPrinciples.Composition;

public class Car
{
    private readonly Engine _engine = new Engine();
    private readonly Wheels _wheels = new Wheels();
    private readonly Chassis _chassis = new Chassis();
    private readonly Seats _seats = new Seats();

    public void StartCar()
    {
        _engine.Start();
        _wheels.Rotate();
        _chassis.Support();
        _seats.Sit();

        Console.WriteLine("Car started.");
    }
}
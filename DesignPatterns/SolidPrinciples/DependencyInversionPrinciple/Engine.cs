namespace DesignPatterns.SolidPrinciples.DependencyInversionPrinciple;

public class Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}
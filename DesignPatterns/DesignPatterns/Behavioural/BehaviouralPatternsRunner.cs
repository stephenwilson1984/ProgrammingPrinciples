using DesignPatterns.DesignPatterns.Behavioural.MementoPattern;

namespace DesignPatterns.DesignPatterns.Behavioural;

public static class BehaviouralPatternsRunner
{
    public static void Run()
    {
        // Memento Pattern
        Console.WriteLine("Memento Pattern");
        Console.WriteLine("--------------------");

        MementoPatternExample.Run();

        Console.WriteLine();
    }
}
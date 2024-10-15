using DesignPatterns.SolidPrinciples.DependencyInversionPrinciple;
using DesignPatterns.SolidPrinciples.InterfaceSegregationPrinciple;
using DesignPatterns.SolidPrinciples.LiskovSubstitutionPrinciple;
using DesignPatterns.SolidPrinciples.OpenClosedPrinciple;
using DesignPatterns.SolidPrinciples.SingleResponsibility;

namespace DesignPatterns.SolidPrinciples;

public static class SolidPrinciplesRunner
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("SOLID Principles");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        // Single Responsibility Principle
        Console.WriteLine("** Single Responsibility Principle example **");
        SingleResponsibilityExample.Run();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        // Open/Closed Principle
        Console.WriteLine("** Open/Closed Principle example **");
        OpenClosedPrincipleExample.Run();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        // Liskov Substitution Principle
        Console.WriteLine("** Liskov Substitution Principle example **");
        LiskovSubstitutionPrincipleExample.Run();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        // Interface Segregation Principle
        Console.WriteLine("** Interface Segregation Principle example **");
        InterfaceSegregationPrincipleExample.Run();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        // Dependency Inversion Principle
        Console.WriteLine("** Dependency Inversion Principle example **");
        DependencyInversionPrincipleExample.Run();
    }
}
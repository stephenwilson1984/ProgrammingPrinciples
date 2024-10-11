﻿namespace DesignPatterns.OopPrinciples.Polymorphism;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public int NumberOfWheels { get; set; }

    public override void Start()
    {
        Console.WriteLine("Starting car...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping car...");
    }
}
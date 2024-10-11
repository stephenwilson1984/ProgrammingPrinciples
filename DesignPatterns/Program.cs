using DesignPatterns.OopPrinciples.Abstraction;
using DesignPatterns.OopPrinciples.Composition;
using DesignPatterns.OopPrinciples.Coupling;
using DesignPatterns.OopPrinciples.Encapsulation;
using DesignPatterns.OopPrinciples.Polymorphism;

// Encapsulation example
Console.WriteLine("** Encapsulation example **");
Encapsulation.Run();

Console.WriteLine("----------------------------------------");
Console.WriteLine();

// Abstraction example
Console.WriteLine("** Abstraction example **");
Abstraction.Run();

Console.WriteLine("----------------------------------------");
Console.WriteLine();

// Polymorphism / inheritance example
Console.WriteLine("** Polymorphism / inheritance example **");
Polymorphism.Run();

Console.WriteLine("----------------------------------------");
Console.WriteLine();

// Coupling example
Console.WriteLine("** Coupling example **");
Coupling.Run();

Console.WriteLine("----------------------------------------");
Console.WriteLine();

// Composition example
Console.WriteLine("** Composition example **");
Composition.Run();

// Composition vs Inheritance
// Composition = has-a relationship
// Inheritance = is-a relationship
// Composition is a design principle that allows you to build complex objects by combining simpler objects.
// It is an alternative to inheritance, where a class can inherit from only one superclass.
// Composition is more flexible than inheritance because it allows you to change the behavior of a class at runtime by changing the objects it is composed of.
// Inheritance is more rigid because the behavior of a class is fixed at compile time.
// Composition is also more modular than inheritance because it allows you to reuse the behavior of a class in different contexts by composing it with different objects.
// Inheritance is less modular because it ties the behavior of a class to its superclass, making it harder to reuse the behavior in different contexts.
// Composition is also more testable than inheritance because it allows you to test the behavior of a class in isolation by mocking the objects it is composed of.
// Inheritance is less testable because it ties the behavior of a class to its superclass, making it harder to test the behavior in isolation.
// In general, you should prefer composition over inheritance because it is more flexible, modular, and testable.

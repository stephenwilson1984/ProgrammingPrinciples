namespace DesignPatterns.OopPrinciples.Polymorphism;

public static class PolymorphismExample
{
    public static void Run()
    {
        // Polymorphism is the ability of an object to take on many forms.
        // Inheritance is a way to achieve polymorphism in C#. Inheritance allows a class to inherit the properties and methods of another class.
        // The class that inherits the properties and methods is called the derived class. The class that is inherited from is called the base class.
        // The derived class can override the properties and methods of the base class.

        List<Vehicle> vehicles =
        [
            new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2021,
                NumberOfDoors = 4,
                NumberOfWheels = 4
            },
            new Motorcycle
            {
                Brand = "Honda",
                Model = "CBR1000RR",
                Year = 2021,
                NumberOfWheels = 2
            },
            new Plane
            {
                Brand = "Boeing",
                Model = "747",
                Year = 2021,
                NumberOfEngines = 4
            }
        ];

        // Polymorphism allows us to treat objects of derived classes as objects of their base class.
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"Brand: {vehicle.Brand}");
            Console.WriteLine($"Model: {vehicle.Model}");
            Console.WriteLine($"Year: {vehicle.Year}");
            vehicle.Start();
            vehicle.Stop();
            Console.WriteLine();
        }
    }
}
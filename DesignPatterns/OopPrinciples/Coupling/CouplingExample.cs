namespace DesignPatterns.OopPrinciples.Coupling;

public abstract class CouplingExample
{
    public static void Run()
    {
        // Coupling is the degree of dependency between two classes. It is the measure of how closely connected two classes are.
        // Tight coupling is when a class is dependent on another class. This is bad because it makes the code harder to maintain and test.
        // Loose coupling is when a class is not dependent on another class. This is good because it makes the code easier to maintain and test.

        Order order = new Order(new SmsSender());
        order.PlaceOrder();
    }
}
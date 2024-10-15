namespace DesignPatterns.OopPrinciples.Coupling;

public class Order(INotificationService notificationService)
{
    private readonly INotificationService _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));

    public void PlaceOrder()
    {
        // Place order logic

        _notificationService.SendNotification("Order placed successfully!");
    }
}
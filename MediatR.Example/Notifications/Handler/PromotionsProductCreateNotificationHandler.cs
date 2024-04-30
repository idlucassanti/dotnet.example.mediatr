
namespace MediatR.Example.Notifications.Handler
{
    public class PromotionsProductCreateNotificationHandler : INotificationHandler<ProductCreateNotification>
    {
        public Task Handle(ProductCreateNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Adding product {notification.ProductName} #{notification.ProductId} to the Promotions system");
            return Task.CompletedTask;
        }
    }
}

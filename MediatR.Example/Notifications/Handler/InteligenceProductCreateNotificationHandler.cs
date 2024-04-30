
namespace MediatR.Example.Notifications.Handler
{
    public class InteligenceProductCreateNotificationHandler : INotificationHandler<ProductCreateNotification>
    {
        public Task Handle(ProductCreateNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Adding product {notification.ProductName} #{notification.ProductId} to the Inteligence system");
            return Task.CompletedTask;
        }
    }
}

namespace MediatR.Example.Notifications
{
    public class ProductCreateNotification : INotification
    {
        public ProductCreateNotification(string productName, int productId)
        {
            ProductName = productName;
            ProductId = productId;
        }

        public string ProductName { get; set; }
        public int ProductId { get; set; }
    }
}

namespace MediatR.Example.Requests.Product.ChangeProductPrice
{
    public class ChangeProductPriceRequest : IRequest<Unit>
    {
        public ChangeProductPriceRequest(int productId, decimal newPrice)
        {
            ProductId = productId;
            NewPrice = newPrice;
        }

        public int ProductId { get; set; }
        public decimal NewPrice { get; set; }
    }
}

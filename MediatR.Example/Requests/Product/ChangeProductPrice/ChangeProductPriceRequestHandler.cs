
namespace MediatR.Example.Requests.Product.ChangeProductPrice
{
    public class ChangeProductPriceRequestHandler : IRequestHandler<ChangeProductPriceRequest, Unit>
    {
        public Task<Unit> Handle(ChangeProductPriceRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Changing price of product #{request.ProductId} to {request.NewPrice}");
            return Task.FromResult(Unit.Value);
        }
    }
}

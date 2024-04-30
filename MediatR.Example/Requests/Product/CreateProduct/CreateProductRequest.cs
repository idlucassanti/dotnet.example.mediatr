namespace MediatR.Example.Requests.Product.CreateProduct
{
    public class CreateProductRequest : IRequest<int>
    {
        public CreateProductRequest(string productName)
        {
            ProductName = productName;
        }

        public string ProductName { get; set; }
    }
}

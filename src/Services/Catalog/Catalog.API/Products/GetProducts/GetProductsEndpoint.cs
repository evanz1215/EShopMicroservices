using Catalog.API.Products.CreateProduct;

namespace Catalog.API.Products.GetProducts;

//public record GetProductRequest();
public record GetProductResponse(IEnumerable<Product> Products);

public class GetProductsEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", async (ISender sender) =>
        {
            var result = await sender.Send(new GetProductsQuery());

            var response = result.Adapt<GetProductResponse>();

            return Results.Ok(response);
        })
        .WithName("GetProduct") // 用途給router命名，類似vue router name
        .Produces<CreateProductResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Prodcut")
        .WithDescription("Get Prodcut");
    }
}
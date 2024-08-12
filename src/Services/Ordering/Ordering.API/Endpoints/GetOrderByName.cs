using Ordering.Application.Orders.Queries.GetOrdersByName;

namespace Ordering.API.Endpoints;

//public record GetOrdersByNameRequest(string Name);
public record GetOrderByNameResponse(IEnumerable<OrderDto> Orders);

public class GetOrderByName : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/orders", async (string orderName, ISender sender) =>
        {
            var result = await sender.Send(new GetOrdersByNameQuery(orderName));

            var response = result.Adapt<GetOrderByNameResponse>();

            return Results.Ok(response);
        })
            .WithName("GetOrderByName")
            .Produces<GetOrderByNameResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithSummary("Gets an order by name.")
            .WithDescription("Gets an order by name.");
    }
}

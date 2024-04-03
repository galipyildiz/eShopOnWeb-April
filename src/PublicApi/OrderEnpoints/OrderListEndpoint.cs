using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.eShopWeb.ApplicationCore.Specifications;
using MinimalApi.Endpoint;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class OrderListEndpoint : IEndpoint<IResult, IRepository<Order>>
{
    private readonly IMapper _mapper;

    public OrderListEndpoint(IMapper mapper)
    {
        _mapper = mapper;
    }

    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapGet("api/orders",
            async (IRepository<Order> orderRepository) =>
            {
                return await HandleAsync(orderRepository);
            })
        .Produces<ListOrdersResponse>()
        .WithTags("OrderEndpoints");
    }

    public async Task<IResult> HandleAsync(IRepository<Order> orderRepository)
    {
        var response = new ListOrdersResponse();
        var spec = new OrdersWithItemsSpecification();

        var items = await orderRepository.ListAsync(spec);

        response.Orders.AddRange(items.Select(_mapper.Map<OrderDto>));

        return Results.Ok(response);
    }
}

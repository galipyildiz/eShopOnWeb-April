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

/// <summary>
/// Get a Order Items by Order Id
/// </summary>
public class OrderDetailGetByIdEndpoint : IEndpoint<IResult, GetByOrderIdOrderDetailRequest, IRepository<OrderItem>>
{
    private readonly IMapper _mapper;

    public OrderDetailGetByIdEndpoint(IMapper mapper)
    {
        _mapper = mapper;
    }
    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapGet("api/orders/{orderId}",
            async (int orderId, IRepository<OrderItem> orderItemRepository) =>
            {
                return await HandleAsync(new GetByOrderIdOrderDetailRequest(orderId), orderItemRepository);
            })
            .Produces<GetByOrderIdOrderDetailResponse>()
            .WithTags("OrderEndpoints");
    }

    public async Task<IResult> HandleAsync(GetByOrderIdOrderDetailRequest request, IRepository<OrderItem> repository)
    {
        var response = new GetByOrderIdOrderDetailResponse(request.CorrelationId());

        var spec = new OrderItemsByOrderIdSpec(request.OrderId);
        var items = await repository.ListAsync(spec);
        if (items is null)
            return Results.NotFound();

        if (items.Count == 0)
            return Results.NotFound($"Order Id:{request.OrderId} not exist");

        response.OrderDeatils.AddRange(items.Select(_mapper.Map<OrderDetailDto>));

        return Results.Ok(response);
    }
}

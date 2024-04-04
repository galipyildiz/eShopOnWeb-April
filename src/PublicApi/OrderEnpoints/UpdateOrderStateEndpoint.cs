using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.eShopWeb.ApplicationCore.Entities;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using MinimalApi.Endpoint;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class UpdateOrderStateEndpoint : IEndpoint<IResult, UpdateOrderStateRequest, IRepository<Order>>
{
    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapPut("api/orders",
            [Authorize(Roles = BlazorShared.Authorization.Constants.Roles.ADMINISTRATORS, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] async (UpdateOrderStateRequest request, IRepository<Order> repository) =>
            {
                return await HandleAsync(request, repository);
            })
            .Produces<UpdateOrderStateResponse>()
            .WithTags("OrderEndpoints");
    }

    public async Task<IResult> HandleAsync(UpdateOrderStateRequest request, IRepository<Order> repository)
    {
        var response = new UpdateOrderStateResponse();
        var existingItem = await repository.GetByIdAsync(request.OrderId);
        if (existingItem == null)
        {
            return Results.NotFound();
        }

        existingItem.UpdateState(request.State);
        await repository.UpdateAsync(existingItem);

        var dto = new OrderDto
        {
            BuyerId = existingItem.BuyerId,
            Id = existingItem.Id,
            OrderDate = existingItem.OrderDate,
            OrderState = existingItem.OrderState,
            TotalPrice = existingItem.Total()
        };

        response.Order = dto;
        return Results.Ok(response);
    }
}

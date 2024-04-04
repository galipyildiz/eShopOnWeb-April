using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class UpdateOrderStateResponse : BaseResponse
{
    public OrderDto Order { get; set; }
}

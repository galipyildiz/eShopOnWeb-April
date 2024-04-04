
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class UpdateOrderStateRequest : BaseRequest
{
    public int OrderId { get; set; }
    public OrderStateEnum State { get; set; }
}

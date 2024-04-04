namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class GetByOrderIdOrderDetailRequest : BaseRequest
{
    public int OrderId { get; init; }
    public GetByOrderIdOrderDetailRequest(int orderId)
    {
        OrderId = orderId;
    }
}

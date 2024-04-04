using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;
public class OrderItemsByOrderIdSpec : Specification<OrderItem>
{
    public OrderItemsByOrderIdSpec(int orderId)
    {
        Query.Where(o => o.OrderId == orderId);
    }
}

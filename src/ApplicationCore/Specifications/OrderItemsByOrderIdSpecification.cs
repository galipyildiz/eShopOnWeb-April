using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;
public class OrderItemsByOrderIdSpecification : Specification<OrderItem>
{
    public OrderItemsByOrderIdSpecification(int orderId)
    {
        Query.Where(o => o.OrderId == orderId);
    }
}

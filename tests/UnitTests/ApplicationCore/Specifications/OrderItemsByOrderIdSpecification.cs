using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Specifications;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Specifications;
public class OrderItemsByOrderId
{
    private static readonly int _orderId = 1;

    [Fact]
    public void AllOrderItemsOrderIdExpectedOrderId()
    {
        var spec = new OrderItemsByOrderIdSpecification(_orderId);

        var orderItems = spec.Evaluate(GetTestDataOrderItems());

        Assert.NotNull(orderItems);
        Assert.True(orderItems.All(x => x.OrderId == _orderId));
    }

    private static List<OrderItem> GetTestDataOrderItems()
    {
        var orderItem = new OrderItem(new CatalogItemOrdered(1, "testName", "test.png"), 1, 10)
        {
            OrderId = _orderId,
        };
        var orderItem2 = new OrderItem(new CatalogItemOrdered(2, "testName2", "test2.png"), 2, 2)
        {
            OrderId = _orderId,
        };
        return new List<OrderItem>()
        {
          orderItem,
          orderItem2
        };
    }
}

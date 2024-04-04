using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Specifications;
using NSubstitute;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Specifications;
public class OrdersWithItems
{
    private readonly string _buyerId = "test@mail.com";

    [Fact]
    public void OrderHasOrderItems()
    {
        var spec = new OrdersWithItemsSpecification();
        var orders = spec.Evaluate(GetTestOrdersCollectionWithOrderItems());
        var firstOrder = orders.FirstOrDefault();

        Assert.NotNull(orders);
        Assert.NotNull(firstOrder);
        Assert.True(firstOrder.OrderItems.Count > 0);
    }

    public List<Order> GetTestOrdersCollectionWithOrderItems()
    {
        var testData = new List<Order>();
        var testDataOrderItems = GetTestDataOrderItems();
        var testDataAddress = GetTestDataAddress();

        var order1Mock = Substitute.For<Order>(_buyerId, testDataAddress, testDataOrderItems);

        testData.Add(order1Mock);
        return testData;
    }

    private static List<OrderItem> GetTestDataOrderItems()
    {
        return new List<OrderItem>()
        {
            new OrderItem(new CatalogItemOrdered(1,"testName","test.png"),1,10),
        };
    }

    private static Address GetTestDataAddress()
    {
        return new Address("a", "b", "c", "d", "e");
    }
}

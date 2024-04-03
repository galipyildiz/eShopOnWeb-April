using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using System;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class OrderDto
{
    public string BuyerId { get; private set; }
    public DateTimeOffset OrderDate { get; private set; }
    public OrderStateEnum OrderState { get; private set; } = OrderStateEnum.Approved;
    public decimal TotalPrice { get; set; } = 0.0m;
}

using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using System;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class OrderDto
{
    public int Id { get; set; }
    public string BuyerId { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public OrderStateEnum OrderState { get; set; }
    public decimal TotalPrice { get; set; }
}

using System;

namespace BlazorShared.Models;
public class Order
{
    public string BuyerId { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public OrderStateEnum OrderState { get; set; }
    public decimal TotalPrice { get; set; }
}

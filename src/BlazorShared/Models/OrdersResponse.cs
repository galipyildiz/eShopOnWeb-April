using System.Collections.Generic;

namespace BlazorShared.Models;
public class OrdersResponse
{
    public List<Order> Orders { get; set; } = new List<Order>();
}

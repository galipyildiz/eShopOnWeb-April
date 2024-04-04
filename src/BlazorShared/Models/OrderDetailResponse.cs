using System.Collections.Generic;

namespace BlazorShared.Models;
public class OrderDetailResponse
{
    public List<OrderDetail> OrderDeatils { get; set; } = new List<OrderDetail>();
}

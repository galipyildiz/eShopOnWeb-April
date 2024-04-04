namespace BlazorShared.Models;
public class UpdateOrderStateRequest
{
    public int OrderId { get; set; }
    public OrderStateEnum State { get; set; }
}

namespace BlazorShared.Models;
public class OrderDetail
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
    public int Units { get; set; }
    public decimal UnitPrice { get; set; }
}

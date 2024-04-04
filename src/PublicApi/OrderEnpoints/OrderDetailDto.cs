namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class OrderDetailDto
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
    public int Units { get; set; }
    public decimal UnitPrice { get; set; }
}

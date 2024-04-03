using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Interfaces;
using BlazorShared.Models;

namespace BlazorAdmin.Services;

public class OrdersService : IOrdersService
{
    private readonly HttpService _httpService;
    public OrdersService(HttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<List<Order>> GetOrdersAsync()
    {
        var orderList = await _httpService.HttpGet<OrdersResponse>($"orders");

        return orderList.Orders;
    }
}

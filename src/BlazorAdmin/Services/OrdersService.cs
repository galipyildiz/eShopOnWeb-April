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
        var response = await _httpService.HttpGet<OrdersResponse>($"orders");

        return response.Orders;
    }

    public async Task<List<OrderDetail>> GetOrderDetailsAsync(int orderId)
    {
        var response = await _httpService.HttpGet<OrderDetailResponse>($"orders/{orderId}");

        return response.OrderDeatils;
    }

    public async Task<Order> UpdateOrderState(UpdateOrderStateRequest request)
    {
        var response = await _httpService.HttpPut<UpdateOrderResponse>($"orders", request);

        return response.Order;
    }
}

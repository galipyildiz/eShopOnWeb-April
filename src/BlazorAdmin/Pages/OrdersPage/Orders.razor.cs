using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAdmin.Helpers;
using BlazorAdmin.Services;
using BlazorShared.Interfaces;
using BlazorShared.Models;

namespace BlazorAdmin.Pages.OrdersPage;

public partial class Orders : BlazorComponent
{
    [Microsoft.AspNetCore.Components.Inject]
    public IOrdersService OrdersService { get; set; }
    private List<Order> orders = new List<Order>();
    private OrderDetails OrderDetailsComponent { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            orders = await OrdersService.GetOrdersAsync();
            CallRequestRefresh();
        }

        await base.OnAfterRenderAsync(firstRender);
    }
    private async void DetailsClick(int id)
    {
        await OrderDetailsComponent.Open(id);
    }
    private async void ReloadOrders()
    {
        orders = await OrdersService.GetOrdersAsync();
        StateHasChanged();
    }
}

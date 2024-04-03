using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Models;

namespace BlazorShared.Interfaces;
public interface IOrdersService
{
    Task<List<Order>> GetOrdersAsync();
}

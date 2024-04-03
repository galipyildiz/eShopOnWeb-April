using System;
using System.Collections.Generic;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class ListOrdersResponse : BaseResponse
{
    public ListOrdersResponse(Guid correlationId) : base(correlationId)
    {

    }
    public ListOrdersResponse()
    {
    }
    public List<OrderDto> Orders { get; set; } = new List<OrderDto>();
}

using System;
using System.Collections.Generic;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class GetByOrderIdOrderDetailResponse : BaseResponse
{
    public GetByOrderIdOrderDetailResponse(Guid correlationId) : base(correlationId)
    {

    }
    public GetByOrderIdOrderDetailResponse()
    {
    }
    public List<OrderDetailDto> OrderDeatils { get; set; } = new List<OrderDetailDto>();
}

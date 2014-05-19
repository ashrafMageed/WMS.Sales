using System;
using System.Collections.Generic;

namespace Sales.Endpoint
{
    public class PurchaseOrder
    {
        public Guid OrderId { get; set; }
        public List<Guid> ProductIds { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneSysWpfApp.Manager
{
    class Order
    {
        public string OrderId { get ; set; }
        public string UserId { get; set; }
        public string PlaneId { get; set; }
        public Order(string orderId, string userId1, string planeId1)
        {
            OrderId = orderId;
            UserId = userId1;
            PlaneId = planeId1;
        }


    }
}

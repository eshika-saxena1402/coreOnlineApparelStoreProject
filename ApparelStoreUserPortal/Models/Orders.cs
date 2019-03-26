using System;
using System.Collections.Generic;

namespace ApparelStoreUserPortal.Models
{
    public partial class Orders
    {
        public Orders()
        {
            FeedBacks = new HashSet<FeedBacks>();
            OrderProducts = new HashSet<OrderProducts>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderAmount { get; set; }
        public int CustomerId { get; set; }

        public Customers Customer { get; set; }
        public ICollection<FeedBacks> FeedBacks { get; set; }
        public ICollection<OrderProducts> OrderProducts { get; set; }
    }
}

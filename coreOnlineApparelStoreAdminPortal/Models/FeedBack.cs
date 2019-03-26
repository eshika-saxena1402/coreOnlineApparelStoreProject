using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace coreOnlineApparelStoreAdminPortal.Models
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        [Column(Order = 0), Key, ForeignKey("Product")]
        public int ProductId { get; set; }
        [Column(Order = 0), Key, ForeignKey("Order")]
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public string Message { get; set; }
      
    }
}

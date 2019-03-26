using System;
using System.Collections.Generic;

namespace ApparelStoreUserPortal.Models
{
    public partial class FeedBacks
    {
        public int FeedBackId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string Message { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}

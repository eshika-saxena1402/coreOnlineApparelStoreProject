using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApparelStoreUserPortal.Models
{
    public partial class FeedBacks
    {
        public int FeedBackId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public string Message { get; set; }

        public Customers Customer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApparelStoreUserPortal.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        [Required]
        public string CustomerFirstName { get; set; }
        [Required]
        public string CustomerLastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        public int ZipCode { get; set; }
        [Required]
        public bool SameAddress { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}

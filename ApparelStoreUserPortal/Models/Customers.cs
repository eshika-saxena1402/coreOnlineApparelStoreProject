using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApparelStoreUserPortal.Models
{
    public partial class Customers
    {
        public Customers()
        {
            FeedBacks = new HashSet<FeedBacks>();
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
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
         ErrorMessage = "Please enter valid email id.")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }   
        public string Address2 { get; set; }
        [Required]
        public string Country { get; set; }
        public string Country2 { get; set; }
        public string State2 { get; set; }
        [Required]
        public int ZipCode { get; set; }
        public int ZipCode2 { get; set; }
        [Required]
        public bool SameAddress { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        public long AlternatePhoneNumber { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string State { get; set; }

        public Carts Carts { get; set; }
        public ICollection<FeedBacks> FeedBacks { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}

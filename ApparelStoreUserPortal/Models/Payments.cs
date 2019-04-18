using System;
using System.Collections.Generic;

namespace ApparelStoreUserPortal.Models
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CardDigit { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int StripeSettingsId { get; set; }
        public int CustomerId { get; set; }
        public Orders Order { get; set; }
        public StripeSettings StripeSettings { get; set; }
    }
}

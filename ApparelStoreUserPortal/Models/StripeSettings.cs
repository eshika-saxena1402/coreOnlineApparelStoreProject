using System;
using System.Collections.Generic;

namespace ApparelStoreUserPortal.Models
{
    public partial class StripeSettings
    {
        public int StripeSettingsId { get; set; }
        public string SecretKey { get; set; }
        public string PublishableKey { get; set; }
        public Payments Payments { get; set; }
    }
}

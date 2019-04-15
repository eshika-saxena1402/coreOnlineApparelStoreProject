﻿using System;
using System.Collections.Generic;

namespace ApparelStoreUserPortal.Models
{
    public partial class Managers
    {
        public int ManagerId { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerPassword { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerAddress { get; set; }
        public string ManagerCountry { get; set; }
        public string ManagerState { get; set; }
        public int ManagerZipCode { get; set; }
        public long ManagerPhoneNumber { get; set; }
        public string ManagerGender { get; set; }
    }
}

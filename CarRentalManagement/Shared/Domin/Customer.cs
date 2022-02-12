﻿using System;
using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domin
{
    public class Customer : BaseDomainModel
    {
        public string DrivingLicense { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }

    }
}
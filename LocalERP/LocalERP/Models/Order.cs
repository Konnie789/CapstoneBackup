﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalERP.Models
{
    public class Order
    {
        public int ID { get; set; }
        public Workorder Workorder { get; set; }
        public Vendor Vendor { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateReceived { get; set; }
    }
}

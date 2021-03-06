﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalERP.Models
{
    public class Material
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public MaterialCategory Category { get; set; }
        public MaterialType Type { get; set; }
        public float QuantityInStock { get; set; }
        public string Details { get; set; }
    }
}

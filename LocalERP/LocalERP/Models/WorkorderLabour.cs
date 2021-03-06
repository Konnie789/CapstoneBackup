﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalERP.Models
{
    public class WorkorderLabour
    {
        public int ID { get; set; }
        public Workorder Workorder { get; set; }
        public LabourType LabourType { get; set; }
        public float Hours { get; set; }
        public DateTime DateCompleted { get; set; } // Does this matter?
    }
}

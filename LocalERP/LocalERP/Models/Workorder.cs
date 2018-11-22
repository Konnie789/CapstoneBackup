using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocalERP.Models;

namespace LocalERP.Models
{
    public class WorkorderContext : DbContext
    {
        public WorkorderContext(DbContextOptions<WorkorderContext> options)
            : base(options)
        { }

        public DbSet<Workorder> Workorders { get; set; }

        public DbSet<LocalERP.Models.Vendor> Vendor { get; set; }
    }

    public class Workorder
    {
        public int ID { get; set; }
        public WorkorderStatus Status { get; set; }
        // public WorkorderUse Use { get; set; }
        // public Faculty Faculty { get; set; }
        // public Semester Semester { get; set; } // Enum? Is it even needed?
        public string Description { get; set; }
        public bool QuoteRequested { get; set; }

        // Is a "TotalOtherCosts" needed?
        public decimal TotalMaterialCost { get; set; }
        public decimal TotalLabourCost { get; set; }
        public decimal TotalCost { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateRequiredBy { get; set; }
        public DateTime DateCompleted { get; set; }
        public DateTime DatePickedUp { get; set; }

        // public TYPE SignatureForPickup { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientName { get; set; }

        public decimal EstMaterialCost { get; set; }
        public decimal EstLabourCost { get; set; }
        public decimal EstOtherCost { get; set; } // Needed?
        public decimal EstTotalCost { get; set; }
        public DateTime EstDeliveryDate { get; set; }

        // public TYPE ChargeAccount { get; set; }
        public string AuthorizedBy { get; set; }
        // public TYPE AuthorizedBySignature { get; set; }
        // public Invoice Invoice { get; set; }
    }
}

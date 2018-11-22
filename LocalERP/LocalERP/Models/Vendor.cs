using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalERP.Models
{
    public class Vendor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebsiteURL { get; set; }
    }
}

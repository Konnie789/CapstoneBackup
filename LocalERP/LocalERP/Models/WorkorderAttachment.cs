using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalERP.Models
{
    public class WorkorderAttachment
    {
        public int ID { get; set; }
        public Workorder Workorder { get; set; }
        public AttachmentType Type { get; set; }
        public string FileLocation { get; set; }
    }
}

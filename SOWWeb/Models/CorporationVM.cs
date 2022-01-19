using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Models
{
    public class CorporationVM
    {
        public long CorporationNumber { get; set; }

        public string CorporationName { get; set; }

        public string Status { get; set; }

        public string CorporationKind { get; set; }

        public string CorporationResidency { get; set; }

        public decimal AccountBalance { get; set; }
    }
}

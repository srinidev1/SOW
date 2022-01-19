using System;
using System.Collections.Generic;
using System.Text;

namespace SOWWeb.Core.Entities
{
    public class Corporation
    {
        public Corporation()
        {

        }

        public long CorporationNumber { get; set; }

        public string CorporationName { get; set; }

        public string Status { get; set; }

        public string CorporationKind { get; set; }

        public string CorporationResidency { get; set; }

        public decimal AccountBalance { get; set; }
    }
}


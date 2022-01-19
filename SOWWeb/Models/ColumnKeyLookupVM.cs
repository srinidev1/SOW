using SOWWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Models
{
    public class LookupVM
    {
        public int LookupId { get; set; }

        public string LookupCode { get; set; }

        public string LookupValue { get; set; }
    }

    public class LookupsVM
    {
        public string LookupKey { get; set; }

        public List<LookupVM> Values { get; set; } = new List<LookupVM>();
    }
}

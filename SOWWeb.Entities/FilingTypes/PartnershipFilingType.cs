using SOWWeb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOWWeb.Core.FilingTypes
{
    /// <summary>
    /// Represents the Partnership filing, values are hard coded for demo purpose
    /// </summary>
    public class PartnershipFilingType : IFilingType
    {
        public decimal GetFilingFee()
        {
            return 25;
        }

        public string GetFilingType()
        {
            return "Partnership";
        }

        public string GetFilingTypeCode()
        {
            return "P";
        }
    }
}

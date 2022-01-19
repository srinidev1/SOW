using SOWWeb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOWWeb.Core.FilingTypes
{
    /// <summary>
    /// Represents the foreign filing, values are hard coded for demo purpose
    /// </summary>
    public class ForeignFilingType : IFilingType
    {
        public decimal GetFilingFee()
        {
            return 100;
        }

        public string GetFilingType()
        {
            return "Foreign";
        }

        public string GetFilingTypeCode()
        {
            return "F";
        }
    }
}

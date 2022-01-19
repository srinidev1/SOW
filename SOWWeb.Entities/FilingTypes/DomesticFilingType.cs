using SOWWeb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOWWeb.Core.FilingTypes
{
    /// <summary>
    /// Represents the domestic filing, values are hard coded for demo purpose
    /// </summary>
    public class DomesticFilingType : IFilingType
    {

        public decimal GetFilingFee()
        {
            return 50;
        }

        public string GetFilingType()
        {
            return "Domestic";
        }

        public string GetFilingTypeCode()
        {
            return "D";
        }
    }
}

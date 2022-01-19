using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Models
{
    public class FilingResponseVM
    {
        public FilingResponseVM()
        {
            FilingTypes = new List<SelectListItem>();
            FilingTypes.Add(new SelectListItem
            { Text = "Domestic", Value = "D" });
            FilingTypes.Add(new SelectListItem
            { Text = "Foreign", Value = "F" });
            FilingTypes.Add(new SelectListItem
            { Text = "Partnership", Value = "P" });

            SelectedFilingType = "D";
        }
        public string ResponseMessage { get; set; }

        public List<SelectListItem> FilingTypes { get; set; }

        public string SelectedFilingType { get; set; }
    }

    /// <summary>
    /// Represents the filing types
    /// </summary>
    public class FilingType
    {
        public FilingType()
        {

        }

        public FilingType(string filingTypeCode,string filingTypeDesc)
        {
            FilingTypeCode = filingTypeCode;
            FilingTypeDesc = filingTypeDesc;
        }
        public string FilingTypeCode { get; set; }

        public string FilingTypeDesc { get; set; }
    }
}

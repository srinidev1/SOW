using System;
using System.Collections.Generic;
using System.Text;

namespace SOWWeb.Core.Interfaces
{
    public interface IFilingType
    {
        string GetFilingType();

        string GetFilingTypeCode();

        decimal GetFilingFee();
    }
}

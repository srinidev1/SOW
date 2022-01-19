using SOWWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOWWeb.Services
{
    public class AssessmentService
    {

        public string GetHelloMessage()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello-");

            for (int counter = 100; counter <= 1000; counter = counter + 100)
            {
                sb.Append(counter + ",");
            }
            return sb.ToString().Substring(0, sb.ToString().LastIndexOf(","));
        }

        public IList<Corporation> GetCorporationList()
        {
            var corporationList = new List<Corporation>
            {
                new Corporation
                {
                    CorporationNumber = 6264,
                    CorporationName = "TEST Corp",
                    Status = "Goodstanding"
                },
                new Corporation
                {
                    CorporationNumber = 62645,
                    CorporationName = "TEST Corp1",
                    Status = "Goodstanding"
                },
                new Corporation
                {
                    CorporationNumber = 62646,
                    CorporationName = "TEST Corp2",
                    Status = "Goodstanding"
                }
            };

            return corporationList;
        }

        public IList<Corporation> GetAlternateEntityList()
        {
            var alternateEntityList = new List<Corporation>
            {
                new Corporation
                {
                    CorporationNumber = 6264,
                    CorporationName = "TEST LLC",
                    Status = "Goodstanding"
                },
                new Corporation
                {
                    CorporationNumber = 62645,
                    CorporationName = "TEST LLC1",
                    Status = "Goodstanding"
                },
                new Corporation
                {
                    CorporationNumber = 62646,
                    CorporationName = "TEST LLC2",
                    Status = "Cease Goodstanding"
                }
            };

            return alternateEntityList;
        }
    }
}
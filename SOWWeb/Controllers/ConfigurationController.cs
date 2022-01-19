using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SOWWeb.Core.Entities;
using SOWWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly string _corporationKind = "CorporationResidency";
        private readonly string _corporationResidency = "CorporationKind";
        private List<Lookup> lstLookupResidency;
        private List<Lookup> lstLookupKind;
        //public ConfigurationController(IConfiguration configuration, IOptions<List<Lookup>> namedOptionsAccessor)
        public ConfigurationController(IConfiguration configuration, IOptionsSnapshot<List<Lookup>> lookupOptionsAccessor)
        {
            lstLookupResidency = lookupOptionsAccessor.Get(_corporationResidency);
            lstLookupKind = lookupOptionsAccessor.Get(_corporationKind);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConfigValues()
        {
            var model = new List<LookupsVM>();

            var kindLookupsVM = new LookupsVM();
            kindLookupsVM.LookupKey = _corporationKind;
            for (int kindCounter=0;kindCounter < lstLookupKind.Count;kindCounter++)
            {
                var lookUpVM = new LookupVM();
                lookUpVM.LookupCode = lstLookupKind[kindCounter].LookupCode;
                lookUpVM.LookupId = lstLookupKind[kindCounter].LookupId;
                lookUpVM.LookupValue = lstLookupKind[kindCounter].LookupValue;
                kindLookupsVM.Values.Add(lookUpVM);
            }
            model.Add(kindLookupsVM);

            var residencyLookupsVM = new LookupsVM();
            residencyLookupsVM.LookupKey = _corporationResidency;
            for (int residencyCounter = 0; residencyCounter < lstLookupResidency.Count; residencyCounter++)
            {
                var lookUpVM = new LookupVM();
                lookUpVM.LookupCode = lstLookupResidency[residencyCounter].LookupCode;
                lookUpVM.LookupId = lstLookupResidency[residencyCounter].LookupId;
                lookUpVM.LookupValue = lstLookupResidency[residencyCounter].LookupValue;
                residencyLookupsVM.Values.Add(lookUpVM);
            }
            model.Add(residencyLookupsVM);

            return View(model);
        }
    }
}

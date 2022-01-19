using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using SOWWeb.Core.Entities;
using SOWWeb.Core.FilingTypes;
using SOWWeb.Core.Interfaces;
using SOWWeb.Models;
using SOWWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Controllers
{
    public class AssessmentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly INotyfService _notyfy;

        public AssessmentController(
            IMapper mapper, INotyfService notyfy)
        {
            _mapper = mapper;
            _notyfy = notyfy;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Hello
        /// <summary>
        /// Returns the Hello string
        /// </summary>
        /// <returns></returns>
        public IActionResult Hello()
        {
            ViewBag.HelloString = new AssessmentService().GetHelloMessage();
            return View();
        }

        #endregion

        #region Search
        public IActionResult CorporationSearch()
        {
            var corporationList = new AssessmentService().GetCorporationList();
            return View(_mapper.Map<IList<Corporation>, IList<CorporationVM>>(corporationList));
        }

        public IActionResult AlternateEntitySearch()
        {
            var alternateEntityList = new AssessmentService().GetAlternateEntityList();
            return View(_mapper.Map<IList<Corporation>, IList<CorporationVM>>(alternateEntityList));
        }

        #endregion

        #region ValidatePriority
        public IActionResult ValidatePriority()
        {
            var myViewModel = new MyViewModel();
            return View(myViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidatePriority(MyViewModel myViewModel)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Index");
                _notyfy.Success("Validation successful.");
            }
            return View();
        }

        #endregion

        #region Filings
        public IActionResult Filings()
        {
            FilingResponseVM filingResponseVM = new FilingResponseVM();
            filingResponseVM.ResponseMessage = string.Empty;

            //filingResponseVM.FilingTypes = GetFilingTypes();

            return View(filingResponseVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilingType(FilingResponseVM filingResponse)
        {
            if (ModelState.IsValid)
            {
                IFilingType filingType;

                string selectedFilingType = Convert.ToString(Request.Form["SelectedFilingType"]);

                filingType = GetFilingType(selectedFilingType);

                filingResponse.ResponseMessage = "Filing Fee For Selected Filing :" + filingType.GetFilingType();
                filingResponse.SelectedFilingType = selectedFilingType;
                //filingResponse.FilingTypes = GetFilingTypes();

                RedirectToAction("Index");
            }
            return View("Filings",filingResponse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilingFee(FilingResponseVM filingResponse)
        {
            if (ModelState.IsValid)
            {
                IFilingType filingType;

                string selectedFilingType = Convert.ToString(Request.Form["SelectedFilingType"]);

                filingType = GetFilingType(selectedFilingType);

                filingResponse.ResponseMessage = "Filing Fee For Selected Filing : " + filingType.GetFilingFee().ToString("C");
                filingResponse.SelectedFilingType = selectedFilingType;
                //filingResponse.FilingTypes = GetFilingTypes();

                RedirectToAction("Index");
            }
            return View("Filings", filingResponse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilingTypeCode(FilingResponseVM filingResponse)
        {
            if (ModelState.IsValid)
            {
                IFilingType filingType;

                string selectedFilingType = Convert.ToString(Request.Form["SelectedFilingType"]);

                filingType = GetFilingType(selectedFilingType);

                filingResponse.ResponseMessage = "Filing Type Code Selected : " + filingType.GetFilingTypeCode();
                filingResponse.SelectedFilingType = selectedFilingType;
                //filingResponse.FilingTypes = GetFilingTypes();

                RedirectToAction("Index");
            }
            return View("Filings", filingResponse);
        }

        private IFilingType GetFilingType(string selectedFilingType)
        {
            IFilingType filingType;
            if (string.Compare(selectedFilingType, "D", true) == 0)
            {
                filingType = new DomesticFilingType();
            }
            else if (string.Compare(selectedFilingType, "F", true) == 0)
            {
                filingType = new ForeignFilingType();
            }
            else
            {
                filingType = new PartnershipFilingType();
            };

            return filingType;
        }
       
        /// <summary>
        /// Return the filing type lookup values
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> GetFilingTypes()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem
            { Text = "Domestic", Value = "D" });
            items.Add(new SelectListItem
            { Text = "Foreign", Value = "F" });
            items.Add(new SelectListItem
            { Text = "Partnership", Value = "P" });

           

            return items;
        }

        #endregion
    }
}

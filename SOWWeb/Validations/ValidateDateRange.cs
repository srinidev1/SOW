using SOWWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Validations
{
    public class ValidateDateRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var myViewModel = (MyViewModel)validationContext.ObjectInstance;

            int priority = myViewModel.Priority;
            //omitted the conditions to check 0 or lesser values.

            if(!myViewModel.DateEnd.HasValue || !myViewModel.DateStart.HasValue)
            {
                return new ValidationResult("Date range is required.");
            }

            double totalDays = myViewModel.DateEnd.Value.Subtract(myViewModel.DateStart.Value).Days;
            bool isSuccess = false;
            var validationMessage = string.Empty;

            if (priority < 1000)
            {
                if(totalDays < 0 || totalDays > 90)
                {
                    validationMessage = "The date range should be under 90 days.";
                }
                else
                {
                    isSuccess = true;
                }
            }
            else if(priority >= 1000 && priority < 5000)
            {
                if (totalDays < 90 || totalDays > 180)
                {
                    validationMessage = "The date range should be between 90 and 180 days.";
                }
                else
                {
                    isSuccess = true;
                }
            }
            else
            {
                if(totalDays < 180)
                {
                    validationMessage = "The date range should be more than 180 days.";
                }
                else
                {
                    isSuccess = true;
                }
            }
            
            if(isSuccess)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(validationMessage);
            }
        }
    }
}

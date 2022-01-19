using SOWWeb.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Models
{
    public class MyViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a Priority greater than or equal to {1}")]
        public int Priority { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateStart { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [ValidateDateRange]
        public DateTime? DateEnd { get; set; }

    }
}

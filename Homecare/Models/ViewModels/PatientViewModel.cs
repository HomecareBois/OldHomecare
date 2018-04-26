using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homecare.Models.ViewModels
{
    public class PatientViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "CPR is required")]
        public string cpr { get; set; }

        [Required(ErrorMessage = "Street name is required")]
        public string roadname { get; set; }

        [Required(ErrorMessage = "House number is required")]
        public string number { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string cityName { get; set; }

        [Required(ErrorMessage = "Zipcode is required")]
        public string zipCode { get; set; }

        [Required(ErrorMessage = "Phonenumber is required")]
        public string phonenumber { get; set; }

        [Required(ErrorMessage = "Relative phonenumber is required")]
        public string relativePhonenumber { get; set; }
    }
}
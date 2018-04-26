using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homecare.Models.ViewModels
{
    public class PatientViewModel
    {
        public string name { get; set; }
        public string cpr { get; set; }
        public string roadname { get; set; }
        public string number { get; set; }
        public string cityName { get; set; }
        public string zipCode { get; set; }
        public string phonenumber { get; set; }
        public string relativePhonenumber { get; set; }
    }
}
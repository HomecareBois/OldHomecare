using Homecare.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homecare.Models.ViewModels
{
    public class PatientParentViewcs
    {
        public Patient patient { get; set; }
        public Address address { get; set; }
        public Phone phone { get; set; }
    }
}
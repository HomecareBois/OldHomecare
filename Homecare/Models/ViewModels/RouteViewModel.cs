﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homecare.Models.ViewModels
{
    public class RouteViewModel
    {

        public string caretaker { get; set; }

        public DateTime date { get; set; }

        public DateTime time { get; set; }

        public string patientCpr { get; set; }
        
    }
}
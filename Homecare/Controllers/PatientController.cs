using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homecare.Models.DataModels;
using Homecare.Models.ViewModels;

namespace Homecare.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PatientList ()
        {
            using (HomecareDBEntities db = new HomecareDBEntities())
            {
                return View(db.Patients.ToList());
            }
        }

        

        public ActionResult CreatePatient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePatient(PatientViewModel inputData)
        {
            if (ModelState.IsValid)
            {
                using (HomecareDBEntities db = new HomecareDBEntities())
                {
                    var c = new City
                    {
                        city_name = inputData.cityName,
                        zipcode = inputData.zipCode
                    };

                    db.Cities.Add(c);
                    db.SaveChanges();

                    var cityId = db.Cities.FirstOrDefault(ci => ci.city_name == inputData.cityName).id_city;

                    var phone = new Phone
                    {
                        phone_number = inputData.phonenumber,
                    };
                    db.Phones.Add(phone);
                    db.SaveChanges();

                    var phoneId = db.Phones.FirstOrDefault(pi => pi.phone_number == inputData.phonenumber).id_phone;

                    var address = new Address
                    {
                        road_name = inputData.roadname,
                        number = inputData.number,
                        fk_city_address = cityId
                    };
                    db.Addresses.Add(address);
                    db.SaveChanges();

                    var addressId = db.Addresses
                        .FirstOrDefault(ai =>
                        ai.road_name == inputData.roadname &&
                        ai.number == inputData.number)
                        .id_address;

                    var p = new Patient
                    {
                        patient_name = inputData.name,
                        cpr = inputData.cpr,
                        relative_phonenumber = inputData.relativePhonenumber,
                        fk_address_patient = addressId,
                        fk_phone_patient = phoneId
                    };

                    db.Patients.Add(p);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = inputData.name + " was created";
            }
            return View();
        }
    }
}
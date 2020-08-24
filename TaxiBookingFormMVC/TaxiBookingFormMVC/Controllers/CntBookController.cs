using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiBookingFormMVC.Models;


namespace TaxiBookingFormMVC.Controllers
{
    public class CntBookController : Controller
    {
        // GET: CntBook
        public ActionResult Index()
        {
            return View();
        }

        BookingHandler BH = new BookingHandler();
        //Insert
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Booking obj)
        {
            if(ModelState.IsValid)
            {
                if(BH.Insert(obj))
                {
                    ViewData["message"] = "Your Booking has been Confirmed for date " + obj.Date;
                    ModelState.Clear();
                }
            }
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessRegisterationMVC.Models;

namespace BusinessRegisterationMVC.Controllers
{
    public class ITEMController : Controller
    {
       

        //INSERT OPERATION************
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BusinessModel obj1)
        {
            if(ModelState.IsValid)
            {
                DB_Handler handler = new DB_Handler();
                if(handler.Insert(obj1))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }





        // READ********
        public ActionResult Index()
        {
            ViewBag.Business_Registeration = "Business item list page";
            DB_Handler handler = new DB_Handler();
            ModelState.Clear();
            return View(handler.Read());
        }




        //UPDATE**********
        [HttpGet]
        public ActionResult Edit(string Email)
        {
            DB_Handler handler = new DB_Handler();
            return View(handler.Read().Find(itemModel => itemModel.Email == Email));
        }
        [HttpPost]
        public ActionResult Edit(BusinessModel obj13,string Email)
        {
            DB_Handler handler = new DB_Handler();
            handler.Update(obj13);
            return View();
        }





        //DELETE***********
        
        public ActionResult delete(string Email)
        {
            DB_Handler handler = new DB_Handler();
            if(handler.Delete(Email))
            {
                ViewBag.Message = "Item Deleted Successfully";
            }
            return View();

        }





        //DETAILS
        public ActionResult Details(string Email)
        {
            DB_Handler handler = new DB_Handler();
            return View(handler.Read().Find(itemModel => itemModel.Email ==Email));
        }
    }
}
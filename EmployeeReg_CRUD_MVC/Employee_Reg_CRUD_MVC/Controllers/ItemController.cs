using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Reg_CRUD_MVC.Models;

namespace Employee_Reg_CRUD_MVC.Controllers
{
    public class ItemController : Controller
    {
       

        //INSERT********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeReg obj)
        {
            if(ModelState.IsValid)
            {
                empDBHandler object1 = new empDBHandler();
                if(object1.InsertItem(obj))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                        
                }
            }
            return View();              
        }



        //READ************
        public ActionResult Index()
        {
            ViewBag.Employee_Registeration = "Employee List Page";
            empDBHandler handler = new empDBHandler();
            ModelState.Clear();
            return View(handler.ReadRecord());
        }


        //UPDATE*************
        [httpGet]
        public ActionResult Edit(string name)
        {
            empDBHandler handler = new empDBHandler();
            return View(handler.ReadRecord().Find(itemModel => itemModel.name == name));
        }
        [HttpPost]
        public ActionResult Edit(string name,EmployeeReg obj)
        {
              empDBHandler handler = new empDBHandler();
                handler.update(obj);
            //return RedirectToAction("Index");
            return View();


        }


        //DELETE*********
        public ActionResult Delete(string name)
        {
            try
            {
                empDBHandler handler = new empDBHandler();
                if(handler.DeleteItem(name))
                {
                    ViewBag.AlertMessage = "Item Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }


        //DETAILS*******
        public ActionResult Details(int Id)
        {
            empDBHandler handler = new empDBHandler();
            return View(handler.ReadRecord().Find(itemModel => itemModel.Id == Id));
        }
    }
}
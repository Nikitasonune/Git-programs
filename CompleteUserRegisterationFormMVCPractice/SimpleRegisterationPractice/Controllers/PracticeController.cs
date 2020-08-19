using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SimpleRegisterationPractice.Models;


namespace SimpleRegisterationPractice.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            return View();
        }


        //INSERT**********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ModelPractice mp)
        {
           if(ModelState.IsValid)
            {
                DBHandler db = new DBHandler();
                if(db.Insert(mp))
                {
                    ViewData["Message"] = "New User " + mp.Full_Name + " is Saved Successfully..!";
                    ModelState.Clear();
                }
            }
            return View();
        }


        // READ
        public ActionResult Read()
        {
            ViewBag.show = "Employee List Page";
            DBHandler db = new DBHandler();
            ModelState.Clear();
            return View(db.Read());
        }



        //UPDATE
        [HttpGet]
        public ActionResult Update(string Email)
        {
            DBHandler db = new DBHandler();
            return View(db.Read().Find(m => m.Email==Email));
        }
        [HttpPost]
        public ActionResult Update(string Email,ModelPractice obj)
        { 
                DBHandler db = new DBHandler();
                if (db.Edit(obj))
                {
                    ViewData["Message"] = "User " + obj.Full_Name + " is Updated Successfully..!";
                    ModelState.Clear();
                }            
            return View();
            
        }




        //DELETE
        public ActionResult Delete(string name)
        {
            try
            {
                DBHandler db = new DBHandler();
                if (db.DeleteRecord(name))
                {
                    ViewData["Message"] = "Record Deleted Successfully";
                }
                return (RedirectToAction("Read"));
            }
            catch { return View(); }  
        }



        //DETAILS
        public ActionResult Details(int id)
        {
            DBHandler db = new DBHandler();
            return View(db.Read().Find(m => m.UserId == id));
        }


    }
}
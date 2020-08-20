using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiBookingFormMVC.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;
using TaxiBookingFormMVC.Models;

namespace TaxiBookingFormMVC.Controllers
{
    public class LoginRegController : Controller
    {

        static string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection con = new SqlConnection(constr);


        //Create Account SignUp Form
        // GET: LoginReg
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AccountRegisteration AR)
        {
            if(ModelState.IsValid)
            {
                AccountHandler AH = new AccountHandler();
                if (AH.Insert(AR))
                {
                    ViewData["Msg"] = "New user " + AR.FullName + "  is Registered Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }



        //Read
        public ActionResult DisplayRecord()
        {
            ViewBag.show = "User SignUp Details List";
            AccountHandler ac = new AccountHandler();
            ModelState.Clear();
            return View(ac.Read());
        }


        //Edit Record

        public ActionResult Edit(string em)
        {
            AccountHandler ah = new AccountHandler();
            return View(ah.Read().Find(m=>m.Email==em));
        }
        [HttpPost]
        public ActionResult Edit(string em,AccountRegisteration obj)
        {
            AccountHandler ah = new AccountHandler();
            if(ah.Update(obj))
            {
                ViewData["msg"] = "User " + obj.FullName + " is updated successfully";
                ModelState.Clear();
            }
            return View();
        }




        //DELETE
        public ActionResult Delete(string em)
        {
            try
            {
                AccountHandler ah = new AccountHandler();
                if (ah.DeleteRecord(em))
                {
                    ViewData["Message"] = "Record Deleted Successfully";
                }
                return (RedirectToAction("DisplayRecord"));
            }
            catch
            {
                return View(); 
            }
        }


        //DETAILS
        public ActionResult Details(int id)
        {
            AccountHandler ah = new AccountHandler();
            return View(ah.Read().Find(m => m.UserId == id));
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountRegisteration obj)
        {
            string query = "select email, password from TaxiLoginRegisteration where email=@email and password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", obj.Email);
            cmd.Parameters.AddWithValue("@password", obj.Password);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(obj.Email=="nik@gmail.com" && obj.Password=="Nikita1")
                {
                    Session["Email"] = obj.Email.ToString();
                    return RedirectToAction("AdminDashboard");
                }
                else
                {
                    Session["Email"] = obj.Email.ToString();
                    return RedirectToAction("UserDashboard");
                }              
            }
            else
            {
                ViewData["Msg"] = "Invalid Login Details";
            }
            con.Close();
            return View();
        }



        //Logout
        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            // return RedirectToAction("Login");
            return RedirectToAction("Login");
        }

        public ActionResult UserDashboard()
        {
            return View();
        }

        public ActionResult AdminDashboard()//only admin can able to Read,Update,Delete Record
        {
            return View();
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SimpleRegisterationPractice.Models;
using System.Web.Security;

namespace SimpleRegisterationPractice.Controllers
{
    public class LoginController : Controller
    {
        static string constr = ConfigurationManager.ConnectionStrings["conString"].ToString();
        SqlConnection con = new SqlConnection(constr);


        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login obj)
        {
            string query = "select Email,Password from SimpleRegisteration where Email=@Email and Password=@Password";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", obj.UserEmail);
            cmd.Parameters.AddWithValue("@Password", obj.UserPassword);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Session["UserEmail"] = obj.UserEmail.ToString();
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewData["Message"] = "User Login Details Failed";
            }
            con.Close();
            return View();
        }



        public ActionResult Dashboard()
        {
            string query = "select Full_Name,Email,Password,Martial_Status,Gender from SimpleRegisteration where Email='" + Session["UserEmail"] + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "SimpleRegisteration");
            foreach (DataRow dr in ds.Tables["SimpleRegisteration"].Rows)
            {
                ViewData["fn"] = dr["Full_Name"].ToString();
                ViewData["em"] = dr["Email"].ToString();
                ViewData["ps"] = dr["Password"].ToString();
                ViewData["status"] = dr["Martial_Status"].ToString();
                ViewData["gen"] = dr["Gender"].ToString();
            }
            return View();
        }

        //second way 
        //this comment section is for Change password coding in DBHandler model and calling that method in controller

        /*public ActionResult ForgetPassword(string Email)
        {
            DBHandler db = new DBHandler();
            return View(db.Read().Find(m => m.Email == Email));
            
        }
        [HttpPost]
        public ActionResult ForgetPassword(Login obj,string Email)
        {
            DBHandler db = new DBHandler();
            if (db.forgetPass(obj))
            {
                ViewData["Message"] = "Password changed successfully";
                ModelState.Clear();
            }
            return View();
        }*/



        public ActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgetPassword(Login obj)
        {
            string qr = "update SimpleRegisteration set Password='" + obj.UserPassword + "' where Email='" + obj.UserEmail + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                ViewData["Message"] = "Password changed successfully";
            }
            else
            {
                ViewData["Message"] = "Something went wrong";
            }
            return View();
        }



        //LOGOUT
        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}
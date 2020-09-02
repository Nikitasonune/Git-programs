using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using TaxiBookingFormMVC.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;
using System;

namespace TaxiBookingFormMVC.Controllers
{
    public class LoginRegController : Controller
    {

        static string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection con = new SqlConnection(constr);

        AccountRegisteration obj = new AccountRegisteration();

        public string UserImage { get; private set; }


        //Create Account SignUp Form
        // GET: LoginReg
        public ActionResult Index()
        {
            return View();
        }



      
        [HttpGet]
        public ActionResult Create()
        {
            return View(obj);
        }
        [HttpPost]
        public ActionResult Create(AccountRegisteration obj,HttpPostedFileBase imgObj)
        {
            if(imgObj!=null)
            {
                obj.UserImage = new byte[imgObj.ContentLength];
                imgObj.InputStream.Read(obj.UserImage, 0, imgObj.ContentLength);
            }
            con.Open();
            string query = "insert into TaxiLoginRegisteration(fullname,email,mobile,password,image)values(@FullName,@Email,@Mobile,@Password,@UserImage)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fullName", obj.FullName);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
            cmd.Parameters.AddWithValue("@Password", obj.Password);
            cmd.Parameters.AddWithValue("@UserImage", obj.UserImage);

            cmd.ExecuteNonQuery();
            con.Close();
            ViewData["Msg"] = "New user " + obj.FullName + "  is Registered Successfully";
            return View(obj);

            /*if(ModelState.IsValid)
            {
                AccountHandler AH = new AccountHandler();
                if (AH.Insert(AR))
                {
                    ViewData["Msg"] = "New user " + AR.FullName + "  is Registered Successfully";
                    ModelState.Clear();
                }
            }
            return View();*/
        }


        //Read
        public ActionResult DisplayRecord()
        {
            /* ViewBag.show = "User SignUp Details List";
             AccountHandler ac = new AccountHandler();
             ModelState.Clear();
             return View(ac.Read());*/
           
                List<AccountRegisteration> obj2 = new List<AccountRegisteration>();
                string query = "select userid,fullname,email,mobile,password,image from TaxiLoginRegisteration";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);              
                DataSet ds = new DataSet();
               apt.Fill(ds,"TaxiLoginRegisteration");
         
            foreach (DataRow dr in ds.Tables["TaxiLoginRegisteration"].Rows)
            {
                obj2.Add(new AccountRegisteration
                {
                    UserId = Convert.ToInt32(dr["userid"]),
                    FullName = (dr["fullname"]).ToString(),
                    Email = (dr["email"]).ToString(),
                    Mobile = (dr["mobile"]).ToString(),
                    Password = (dr["password"]).ToString(),
                    UserImage = (byte[])dr["image"],
            });
                byte[] imag = (byte[])dr["image"];
                string p = Convert.ToBase64String(imag, 0, imag.Length);
                string pi = "data:image/png;base64," + p;
                //UserImage = pi; 
                //obj.photo = "data:image/png;base64," + p;
                //ViewBag.image = pi;
                AccountRegisteration.image = pi;
            }

                return View(obj2);    
        }


        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(string em,AccountRegisteration ac)
        {
            string m=null;
            string query = "update TaxiLoginRegisteration set fullname='" + ac.FullName + "',mobile='" + ac.Mobile + "',password='" + ac.Password + "' where email='" + ac.Email + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            if(i==1)
            {
                m = "done";
            }
            
            con.Close();
            ViewData["msg"] = m;
            return View();
        }

        //Edit Record

        /*public ActionResult Edit(string em)
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
        }*/




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
        /*public ActionResult Details(int id)
        {
            AccountHandler ah = new AccountHandler();
            return View(ah.Read().Find(m => m.UserId == id));
        }*/

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

        public ActionResult UserDashboard(AccountRegisteration ob)
        {
            List<AccountRegisteration> obj1 = new List<AccountRegisteration>();
           // string fn = Session["UserImage"].ToString();
            con.Open();
            // string query = "select * from TaxiLoginRegisteration where image='"+Session["UserImage"]+"'";
           // List<AccountRegisteration> obj1 = new List<AccountRegisteration>();
            string query = "select * from TaxiLoginRegisteration where email='" + Session["Email"]+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "TaxiLoginRegisteration");
            foreach (DataRow dr in ds.Tables["TaxiLoginRegisteration"].Rows)
            {
                
                ViewData["fullname"] = dr["FullName"].ToString();
                ViewData["email"] = dr["Email"].ToString();
                ViewData["mobile"] = dr["Mobile"].ToString();
                ViewData["password"] = dr["Password"].ToString();
                obj1.Add(new AccountRegisteration
                {
                    //UserId = Convert.ToInt32(dr["userid"]),
                    FullName = (dr["fullname"]).ToString(),
                    Email = (dr["email"]).ToString(),
                    Mobile = (dr["mobile"]).ToString(),
                    Password = (dr["password"]).ToString(),
                    UserImage = (byte[])dr["image"],
                });
                byte[] imag = (byte[])dr["image"];
                string p = Convert.ToBase64String(imag, 0, imag.Length);
                string pi = "data:image/png;base64," + p;
                ViewBag.image = pi;
            }
                
        
                return View(obj);
        }

        public ActionResult AdminDashboard()//only admin can able to Read,Update,Delete Record
        {
            return View();
        }



    }
}
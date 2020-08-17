using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace RegistrationFormCRUD
{
    public partial class UpdateDelete : System.Web.UI.Page
    {
        
        static string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
            }
        }


        //Method For Reading Record
        void show()
        {
            
            string qr = "select UserID,FirstName,MiddleName,LastName,MobileNumber,Email,DateOfBirth,Gender,permanentAddress,CorresAddess,State,City,Pin,Streme,Course from Register";          
            SqlDataAdapter da = new SqlDataAdapter(qr,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            /*int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            SqlCommand cmd = new SqlCommand("delete from student_info where id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            show();*/

            string email = Convert.ToString(GridView1.DataKeys[e.RowIndex].Values["Email"].ToString());
            SqlCommand cmd = new SqlCommand("delete from Register where email=@Email", con);
            cmd.Parameters.AddWithValue("@Email", email);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            show();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // int id=Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["UserID"].ToString());
            
            Label txtid = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox txtFName = GridView1.Rows[e.RowIndex].FindControl("TextBox14") as TextBox;
            TextBox txtMName = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox txtLName = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox txtMobile = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox txtEmail = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox txtDOB = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            TextBox txtGender = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
            TextBox txtPermanentAdd = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
            TextBox txtCorrespondanceAdd = GridView1.Rows[e.RowIndex].FindControl("TextBox8") as TextBox;
            TextBox txtState = GridView1.Rows[e.RowIndex].FindControl("TextBox9") as TextBox;
            TextBox txtCity = GridView1.Rows[e.RowIndex].FindControl("TextBox10") as TextBox;
            TextBox txtPin = GridView1.Rows[e.RowIndex].FindControl("TextBox11") as TextBox;
            TextBox txtStreme = GridView1.Rows[e.RowIndex].FindControl("TextBox12") as TextBox;
            TextBox txtCourse = GridView1.Rows[e.RowIndex].FindControl("TextBox13") as TextBox;

            //SqlCommand cmd = new SqlCommand("update Register set FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,MobileNumber=@MobileNumber,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender,permanentAddress=@permanentAddress,CorresAddess=@CorresAddess,State=@State,City=@City,Pin=@Pin,Streme=@Streme,Course=@Course where UserID=@UserID", con);
            SqlCommand cmd = new SqlCommand("update Register set FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,MobileNumber=@MobileNumber,DateOfBirth=@DateOfBirth,Gender=@Gender,permanentAddress=@permanentAddress,CorresAddess=@CorresAddess,State=@State,City=@City,Pin=@Pin,Streme=@Streme,Course=@Course where Email=@Email", con);
            cmd.Parameters.AddWithValue("@UserID", txtid.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
            cmd.Parameters.AddWithValue("@MiddleName", txtMName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
            cmd.Parameters.AddWithValue("@MobileNumber", txtMobile.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", txtDOB.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@permanentAddress", txtPermanentAdd.Text);
            cmd.Parameters.AddWithValue("@CorresAddess", txtCorrespondanceAdd.Text);
            cmd.Parameters.AddWithValue("@State", txtState.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Pin", txtPin.Text);
            cmd.Parameters.AddWithValue("@Streme", txtStreme.Text);
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            show();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Student_registeration
{
    public partial class gridview : System.Web.UI.Page
    {
         static string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack)
            {
                show();
            }
        }
            void show()
            {
                string qr = "select Id,firstname,lastname,mobile,gender,dob,caddress,paddress,stream,course,email,status from student_info";
                SqlDataAdapter da = new SqlDataAdapter(qr, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }



            protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
            {
            GridView1.EditIndex = -1;
            show();
        }

            protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
            {
            int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            SqlCommand cmd = new SqlCommand("delete from student_info where id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
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
            int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            TextBox txtfname = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox txtlname = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox txtmobile = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox txtgender = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox txtdob = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            TextBox txtcadd = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
            TextBox txtpadd = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
            TextBox txtstream = GridView1.Rows[e.RowIndex].FindControl("TextBox8") as TextBox;
            TextBox txtcourse = GridView1.Rows[e.RowIndex].FindControl("TextBox9") as TextBox;
            TextBox txtemail = GridView1.Rows[e.RowIndex].FindControl("TextBox10") as TextBox;
            TextBox txtstatus = GridView1.Rows[e.RowIndex].FindControl("TextBox12") as TextBox;

            SqlCommand cmd = new SqlCommand("update student_info set firstname=@firstname,lastname=@lastname,mobile=@mobile,gender=@gender,dob=@dob,caddress=@caddress,paddress=@paddress,stream=stream,course=@course, email=@email,status=@status where id =@Id", con);
            cmd.Parameters.AddWithValue("@firstname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtlname.Text);
            cmd.Parameters.AddWithValue("@mobile", txtmobile.Text);
            cmd.Parameters.AddWithValue("@gender", txtgender.Text);
            cmd.Parameters.AddWithValue("@dob", txtdob.Text);
            cmd.Parameters.AddWithValue("@caddress", txtcadd.Text);
            cmd.Parameters.AddWithValue("@paddress", txtpadd.Text);
            cmd.Parameters.AddWithValue("@stream", txtstream.Text);
            cmd.Parameters.AddWithValue("@course", txtcourse.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@status", txtstatus.Text);
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            show();

        }
        }
    }

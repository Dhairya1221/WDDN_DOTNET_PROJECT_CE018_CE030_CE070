using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dotnet_project1
{
    public partial class Signup : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data source=LAPTOP-MEOGAVAB;initial catalog=Userdata; integrated Security=true ";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(usertxt.Text=="" || emailtxt.Text=="" || passtxt.Text=="" || cpasstxt.Text=="")
            {
                Label2.Text = "FILL UP THE INFORMATION";
            }

            else if ( passtxt.Text != cpasstxt.Text)
            {
                Label3.Text = "PASSWORD AND CONFIRM-PASSWORD ARE NOT SAME";
            }
            else 
            { 
                SqlCommand cmd = new SqlCommand("insert into user_table" + "(Username,Email,Password,CPassword)values(@Username,@Email,@Password,@CPassword)",con);
                cmd.Parameters.AddWithValue("@Username", usertxt.Text);
                cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                cmd.Parameters.AddWithValue("@Password", passtxt.Text);
                cmd.Parameters.AddWithValue("@CPassword", cpasstxt.Text);
                cmd.ExecuteNonQuery();
                Label1.Text = "Signup insert";
                Response.Redirect("Login.aspx");
            }

        }

    }
}
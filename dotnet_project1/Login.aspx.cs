using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dotnet_project1
{
    
    public partial class Login : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Response.Redirect("Homepage.aspx");
            }
            else
                con.ConnectionString = "Data source=LAPTOP-MEOGAVAB;initial catalog=Userdata; integrated Security=true ";
                con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = emailtxt.Text.Trim();
            string pass = passtxt.Text.Trim();
            int i = 0;
            cmd.CommandText = "select * from user_table where Email ='" + emailtxt.Text + "' and Password = '" + passtxt.Text + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "user_table");
            if(ds.Tables[0].Rows.Count>0)
            {
                if(pass == ds.Tables[i].Rows[i]["Password"].ToString())
                {
                    Session["user"] = user;
                    Response.Redirect("Homepage.aspx");
                }
            }
            else
            {
                Label1.Text = "password don't match";
            }
        }
    }
}
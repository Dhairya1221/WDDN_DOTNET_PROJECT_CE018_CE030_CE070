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
    public partial class Homepage : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            con.ConnectionString = "Data source=LAPTOP-MEOGAVAB;initial catalog=Userdata; integrated Security=true ";
            con.Open();
            showdata();
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Mainpage.aspx");
        }
        public void showdata()
        {
            cmd.CommandText = "select * from user_table where Email ='" + Session["user"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            Label1.Text = ds.Tables[0].Rows[0]["Username"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (pentxt.Text == "" || newstxt.Text == "")
            {
                Label2.Text = "FILL UP THE INFORMATION";
            }

           
            else
            {
                SqlCommand cmd = new SqlCommand("insert into data_info" + "(pen_name,data)values(@pen_name,@data)", con);
                cmd.Parameters.AddWithValue("@pen_name", pentxt.Text);
                cmd.Parameters.AddWithValue("@data", newstxt.Text);
                cmd.ExecuteNonQuery();
                Label3.Text = "Data inserteds";
            }
        }
    }
}
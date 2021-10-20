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
    public partial class Mainpage : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data source=LAPTOP-MEOGAVAB;initial catalog=Userdata; integrated Security=true ";
            con.Open();
            GVbind();
        }

        protected void GVbind()
        {
            SqlCommand cmd = new SqlCommand("select * from data_info",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows == true)
            {
                GridView1.DataSource = dr;
                GridView1.DataBind(); 
            }

        }
    }
}
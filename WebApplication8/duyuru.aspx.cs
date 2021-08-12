using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication8
{
    public partial class duyuru : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
           SqlCommand cmd = new SqlCommand("insert into duyurular (baslik,icerik,tarih) values (@baslik,@icerik,@tarih) ", con);
            cmd.Parameters.AddWithValue("@baslik", tb1.Text);
            cmd.Parameters.AddWithValue("@icerik",tb2.Text );
            cmd.Parameters.AddWithValue("@tarih",DateTime.Now.ToShortDateString());
           
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
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
    public  partial class kategori : System.Web.UI.Page
    { SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        public static string urun_sayisi;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();

            kategori k = new kategori();
            
            

        }
        
        public void ver_cek()
        {
            SqlCommand komut = new SqlCommand();      
            komut.Connection = con;
            komut.CommandText = "Select count(adi) from kategori";
          
            komut.ExecuteNonQuery();
            urun_sayisi = komut.ExecuteReader().ToString();
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into kategori (adi) values (@adi) ",con);
            cmd.Parameters.AddWithValue("@adi", TextBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
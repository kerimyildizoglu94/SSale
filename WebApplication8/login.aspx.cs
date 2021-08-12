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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void kontrol()
        {
            
            con.Open();


            SqlCommand komut = new SqlCommand("select *from personel where tc='"+tc.Text+"'and sifre='"+sifre.Text+"'",con);
            SqlDataReader dr = komut.ExecuteReader();
         

            
            
            if (dr.Read())
            {
                Session["personelid"] = dr["id"];
                Session["personelad"] =dr["ad"];
                Session["personelsoyad"] = dr["soyad"];
                Session["personelkidem"] = dr["kidem"];
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write( "Giriş Başarısız");
            }
            con.Close();

        }
     


        protected void Button1_Click(object sender, EventArgs e)
        {
            kontrol();
        }
    }
}
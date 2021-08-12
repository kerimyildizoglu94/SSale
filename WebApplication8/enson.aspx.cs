using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WebApplication8
{
    public partial class enson : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            gunc();

        }
        public void gunc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select musteri.ad,musteri.soyad,urun.ad ,sepet.miktar,sepet.alisfiyati,sepet.totalfiyat,sepet.satinalmatarihi from musteri,sepet,urun where musteri.id=sepet.musteri_id and sepet.urun_id=urun.id and sepet.musteri_id=" + int.Parse(Session["musteriid"].ToString()), con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
      
        void sil()

        {
            if (Session["musteriid"] != null)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("DELETE FROM sepet WHERE musteri_id = " + Convert.ToInt32(Session["musteriid"].ToString()), con);
                cmd1.ExecuteNonQuery();
                con.Close();
                gunc();
                Response.Write("<scrip>alert('Silindi');</scrip>");
            }
            else
            {
                Response.Write("Silindi idare et ");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
          //    sil();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
        }
       
    }
}
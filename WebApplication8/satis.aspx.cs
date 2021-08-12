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
    public partial class satis : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        int id = -1;
        int musteri_id = -1;
        int dongusayisi;

        string[] foto;
        public void fotocek()
        {
            if (Session["resimno"] != null)
            {
                string[] urunler = Session["resimno"].ToString().Split('.');
                foto = new string[urunler.Length];
                for (int i = 0; i < dongusayisi; i++)
                {
                    foto[i] = urunler[i];
                }

                //DataList1.DataSource = foto;
                // DataList1.DataBind();
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Session["secimler"] = null;
                Session["musteriid"] = null;
               
            }
            gunc();
            urun_guncelle();
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            musteri_id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
            Session["musteriid"] = musteri_id.ToString();
            grid3guncelle();
            

        }
        public void gunc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from musteri order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

    
        public void urun_guncelle()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select urun.id,urun.ad,urun.barkod,giren.satis_fiyati,giren.stok from urun,giren where urun.id=giren.urun_id", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView2.DataSource = ds2;
            GridView2.DataBind();
        }
        public void secim_guncelle()
        {
            /*
            if (Session["secimler"] != null)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("select urun.id,urun.ad,urun.barkod,giren.satis_fiyati,giren.stok from urun,giren where urun.id=giren.urun_id and urun.barkod = (" + Session["secimler"] + ")", con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                GridView3.DataSource = ds2;
                GridView3.DataBind();
            }*/

        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from musteri where tc like '%" + TextBox1.Text + "%' or ad like'%" + TextBox1.Text + "%'  or soyad like'%" + TextBox1.Text + "%' or telno like '%" + TextBox1.Text + "%'", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*  string resimno = GridView2.SelectedRow.Cells[2].Text;
              if (Session["secimler"] == null)
              {
                  Session["secimler"] = resimno.ToString();
              }
              else
              {
                  Session["secimler"] += "," + resimno.ToString();
              }
              secim_guncelle();*/
            Session["urunid"] = GridView2.SelectedRow.Cells[0].Text;
            Session["satisfiyati"] = GridView2.SelectedRow.Cells[3].Text;
            Session["alisfiyati"] = GridView2.SelectedRow.Cells[4].Text;


        }



        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from urun,giren where  ( ad like '%" + TextBox2.Text + "%' or barkod like'%" + TextBox2.Text + "%')and urun.id=giren.urun_id  ", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }
        void sepet_ek_le()
        {
            string trh = DateTime.Now.ToShortDateString();
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into sepet (musteri_id,urun_id,satinalmatarihi,alisfiyati,miktar,totalfiyat) values (@musteri_id,@urun_id,@satinalmatarihi,@alisfiyati,@miktar,@totalfiyat)", con);
            cmd.Parameters.AddWithValue("@musteri_id", int.Parse(Session["musteriid"].ToString()));
            cmd.Parameters.AddWithValue("@urun_id", int.Parse(Session["urunid"].ToString()));
            cmd.Parameters.AddWithValue("@satinalmatarihi", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@alisfiyati", int.Parse(Session["alisfiyati"].ToString()));
            cmd.Parameters.AddWithValue("@miktar", 1);
            cmd.Parameters.AddWithValue("@totalfiyat", int.Parse(Session["alisfiyati"].ToString()));
            cmd.ExecuteNonQuery();
            con.Close(); 
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            sepet_ek_le();
            grid3guncelle();
            Button1.Visible = true;
        }
        public void grid3guncelle()
        {if (Session["musteriid"] != null)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("select DISTINCT(sepet.id),  urun.ad,urun.barkod from urun,sepet,musteri where urun.id=sepet.urun_id and sepet.musteri_id=" + int.Parse(Session["musteriid"].ToString()), con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "sepet");
                GridView3.DataSource = ds2;
                GridView3.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("satinalinan.aspx");
        }
    }
}
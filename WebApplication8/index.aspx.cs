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

    public partial class index : System.Web.UI.Page
    {
        

        
        public  double Dolar = 5.555;
        private DataSet dsDovizKur;
        private void DovizKur()
        {
            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow dr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
        
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        public string calisansayisi="1111";
        public string urunsayisi = "2222";
        public string kayıtlımüsteri = "2222";
        public string katagorisayisi = "2222";
        public string alinan = "2222";
        public string aktif;
        public string toplamziyaretci;

        public void ziyaretci_sayisi()
        {
            {
                con.Open();
                string st = "select count(ziyaretciler.id) as sayi from ziyaretciler";
                SqlDataAdapter da = new SqlDataAdapter(st, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                toplamziyaretci = ds.Rows[0][0].ToString();
                con.Close();

            }

        }
        public void aktifurun()

        {
            con.Open();
            string st = "select count(giren.id) as sayi from giren where stok >0";
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            aktif = ds.Rows[0][0].ToString();
            con.Close();

        }
      public  void ziyaretci()
        {
            string ipp = ip_get.Get_ip();
            string trh = DateTime.Now.ToShortDateString();
            if (ziyaretci_kontrol() < 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ziyaretciler(ip,tarih) values ('" + ipp + "','" + trh + "')", con);
              
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        public int ziyaretci_kontrol()
        {
            
           DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From ziyaretciler where ip='" + ip_get.Get_ip().ToString() + "' and tarih='" + DateTime.Now.ToShortDateString() + "'", con);
            da.Fill(ds, "ziyaretciler");
            con.Close();
            return ds.Tables[0].Rows.Count;

        }



        public void personelsayisi()
        {
            con.Open();
            string st = "select count(personel.ad) as sayi from personel";
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            calisansayisi = ds.Rows[0][0].ToString();
            con.Close();

        }
        public void kategori_sayisi()
        {
            con.Open();
            string st = "select count(kategori.id) as sayi from kategori";
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            katagorisayisi = ds.Rows[0][0].ToString();
            con.Close();

        }
        public void km()
        {
            con.Open();
            string st = "select count(musteri.ad) as sayi from musteri";
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            kayıtlımüsteri = ds.Rows[0][0].ToString();
            con.Close();

        }
        void du_yu_ru()
        {
            con.Open();
            string st = "select *from duyurular";
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "duyurular");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                duyuru.Text += "<div> " + ds.Tables[0].Rows[i]["baslik"].ToString() +"</div><div>" +ds.Tables[0].Rows[i]["icerik"].ToString() + "</div>";
            }
            con.Close();

        }
       
        public void kayiyliurun()
        {
            con.Open();
            string st = "select count(urun.ad) as sayi from urun";
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            urunsayisi = ds.Rows[0][0].ToString();
            con.Close();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["personelid"] == null)
            {
                Response.Redirect("login.aspx");
                return;

            }

            du_yu_ru();

            ziyaretci_sayisi();
            personelsayisi();
            km();
            kayiyliurun();
            kategori_sayisi();
            DovizKur();
            aktifurun();
            if (!IsPostBack)
            {
                ziyaretci();
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı giriş</span> " + Session["personelad"].ToString() + " " + Session["personelsoyad"].ToString() + " <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
              
            }
         
        }
    }
}
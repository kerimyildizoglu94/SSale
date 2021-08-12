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
    public partial class personelekle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if (Session["personelkidem"].ToString() == "alt" || Session["personelkidem"] == null)
            {
                Response.Redirect("index.aspx");

            }*/
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string sq = "Select tc from personel where tc=@tc";
            SqlCommand control = new SqlCommand(sq, con);
            control.Parameters.AddWithValue("@tc", tbtc.Text);
            SqlDataReader say = control.ExecuteReader();
            if (say.Read())
            {
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Uyarı</span>" + tbtc.Text + "Veritabanında Kayıtlı" + "  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
                return;
            }
            say.Close();
          
            SqlCommand cmd = new SqlCommand("insert into personel (ad,soyad,tc,dtarihi,email,cinsiyet,sifre,kidem) values (@ad,@soyad,@tc,@dtarihi,@email,@cinsiyet,@sifre,@kidem) ", con);
            cmd.Parameters.AddWithValue("@ad", tbadi.Text);
            cmd.Parameters.AddWithValue("@soyad", tbsoyadi.Text);
            cmd.Parameters.AddWithValue("@tc", tbtc.Text);
            cmd.Parameters.AddWithValue("@dtarihi", tbdogumtarihi.Text);
            cmd.Parameters.AddWithValue("@email", tbemail.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", tbcinsiyet.Text);
            cmd.Parameters.AddWithValue("@sifre", tbsifre.Text);
            cmd.Parameters.AddWithValue("@kidem", tbkidem.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı</span> Kayıt Edildi Gardaşım <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
            texttemizle();
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }
      
       public void texttemizle()
        {
            tbadi.Text = tbcinsiyet.Text = tbdogumtarihi.Text = tbemail.Text = tbkidem.Text = tbsifre.Text = tbsoyadi.Text = tbtc.Text = "";
        }
    }
}
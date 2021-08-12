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
    public partial class musteriekle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kayitbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sq = "Select tc from musteri where tc=@tc";
            SqlCommand control = new SqlCommand(sq, con);
            control.Parameters.AddWithValue("@tc", tbmusteritc.Text);
            SqlDataReader say = control.ExecuteReader();
            if (say.Read())
            {
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Success</span>" + tbmusteritc.Text + "Veritabanında Kayıtlı" + "  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
                return;
            }
            say.Close();
           
            SqlCommand cmd = new SqlCommand("insert into musteri (tc,ad,soyad,email,adres,telno,dtarihi,cinsiyet) values (@tc,@ad,@soyad,@email,@adres,@telno,@dtarihi,@cinsiyet) ", con);
            cmd.Parameters.AddWithValue("@tc", tbmusteritc.Text);
            cmd.Parameters.AddWithValue("@ad", tbmusteriadi.Text);
            cmd.Parameters.AddWithValue("@soyad", tbmusterisoyadi.Text);
            cmd.Parameters.AddWithValue("@email", tbmusterimail.Text);
            cmd.Parameters.AddWithValue("@adres", tbmusteriadres.Text);
            cmd.Parameters.AddWithValue("@telno", tbmusteritel.Text);
            cmd.Parameters.AddWithValue("@dtarihi", tbmusteridtarihi.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", tbmustericinsiyet.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            temizlik();
            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Success</span>Kayıt Yapıldı  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
        }
        public void temizlik() {
            tbmusteriadi.Text = tbmusteriadres.Text = tbmustericinsiyet.Text = tbmusteridtarihi.Text = tbmusterimail.Text = tbmusterisoyadi.Text = tbmusteritc.Text = tbmusteritel.Text = "";
        }
    }
}
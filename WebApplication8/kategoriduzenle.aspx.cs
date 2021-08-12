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
    public partial class kategoriduzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        int id = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            gunc();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void gunc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from kategori order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }
        public void textdoldur()
        {
            tb1.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[0].Text);
            tb2.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[1].Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sqlupdate();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from kategori where adi like '%" + TextBox1.Text + "%' ", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
            Session["id"] = id.ToString();
            textdoldur();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        public void sqlupdate()
        {
            int id = int.Parse(Session["id"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE kategori SET adi=@adi where id=" + id, con);

 
            cmd.Parameters.AddWithValue("@adi", tb2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            gunc();
            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı Güncelleme</span>  Ürün  Güncellendi  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";

        }
    }
}
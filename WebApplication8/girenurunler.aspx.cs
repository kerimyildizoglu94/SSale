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
    public partial class girenurunler : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        int id = -1;
        int id2 = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                combola();
            }
            gunc();

        }
        public void combola()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from kategori ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "adi";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            con.Close();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
            Session["id"] = id.ToString();
        }

       
        public void gunc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from urun where kat_id="+DropDownList1.SelectedValue, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            id2 = int.Parse(DropDownList1.SelectedValue);
           

            Session["id2"] = id2.ToString();
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           con.Open();
            SqlCommand cmd = new SqlCommand("insert into giren (stok,gelisfiyati,gelistarihi,urun_id,satis_fiyati) values (@stok,@gelisfiyati,@gelistarihi,@urun_id,@satis_fiyati) ", con);
            cmd.Parameters.AddWithValue("@stok", int.Parse(tb1.Text));
            cmd.Parameters.AddWithValue("@gelisfiyati", float.Parse(tb2.Text));
            cmd.Parameters.AddWithValue("@gelistarihi", tb3.Text);
            cmd.Parameters.AddWithValue("@urun_id", Session["id"].ToString());
            cmd.Parameters.AddWithValue("@satis_fiyati", float.Parse(tb4.Text));


            cmd.ExecuteNonQuery();
            con.Close();
            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı</span> Stoklar Eklendi <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
          
        }
    }
}
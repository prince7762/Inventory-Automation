using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class customersearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

      
        DataSet ds = new DataSet();
        string s = "select*from customer where cid=" + TextBox1.Text + "";
        datacon dc = new datacon();
        ds = dc.GetData(s);
        if (ds.Tables[0].Rows.Count == 0)
            Response.Write("<script>alert('No Record Found')</script>");
        else
        {
            TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            TextBox1.Text = "";
        }
    }
}
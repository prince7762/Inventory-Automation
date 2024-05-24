using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = "insert into customer values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "')";
        datacon dc = new datacon();
        dc.SetData(s);
        Response.Write("<script>alert('Data inserted')</script>");
    }
}
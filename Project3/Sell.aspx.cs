using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Sell : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime CurrentDate = DateTime.Now;
        TextBox4.Text = CurrentDate.ToShortDateString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s;
        datacon dc = new datacon();
        DataSet ds = new DataSet();
        s = "select*from stock where items_name='" + TextBox1.Text + "'";
        ds = dc.GetData(s);
        if (ds.Tables[0].Rows.Count==0)
        {
            Response.Write("<script>alert('This items is not available')</script>");
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
        }
        else
        {
          
            s = "update stock set quantity=quantity-" + Convert.ToInt32(TextBox2.Text) + " where items_name='" + TextBox1.Text + "'";
            dc.SetData(s);
            s = "insert into sell values(" + Convert.ToInt32(DropDownList1.Text) + ",'" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + ",'" + TextBox4.Text + "')";
            dc.SetData(s);
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
 
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string s = "select*from purchase";
        datacon dc = new datacon();
        ds = dc.GetData(s);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string s = "select*from Sell";
        datacon dc = new datacon();
        ds = dc.GetData(s);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}
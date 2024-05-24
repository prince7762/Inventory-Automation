using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class allcustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string s = "select * from customer";
        datacon dc = new datacon();
        ds = dc.GetData(s);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}
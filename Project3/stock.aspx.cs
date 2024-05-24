using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class stock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
        string s = "Select * from stock";
        datacon dc = new datacon();
        DataSet ds = new DataSet();
        ds = dc.GetData(s);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
  
         string s = "select * from stock where items_name like '%"+ TextBox1.Text +"%'";
          datacon dc = new datacon();
          DataSet ds = new DataSet();  
          ds=dc.GetData(s);
          GridView1.DataSource = ds;
          GridView1.DataBind();
       
          
       
    } 
  

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration; //new directive!! final test!!

public partial class datatest6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //final test2 !!
        string connStr = ConfigurationManager.ConnectionStrings["connStr_Nwind"].ConnectionString;
        OleDbConnection conn = new OleDbConnection(connStr);
        conn.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        cmd.CommandText = "SELECT * FROM [Suppliers]";
        OleDbDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        dr.Close();
        conn.Close();
        
    }
}
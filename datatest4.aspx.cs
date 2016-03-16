using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb; //need this!!

public partial class datatest4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("/");
        Response.Write(path);
        string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + path + "App_Data\\Nwind.mdb";
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
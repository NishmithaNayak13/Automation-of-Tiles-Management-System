using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Windows .Forms ;


public partial class purorview : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from porder where po_no='" +(String ) Session["poo"] + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "pur");
        if (ds.Tables["pur"].Rows.Count > 0)
        {
            CrystalReportViewer1.SelectionFormula = "{porder.po_no}='" + (String)Session["poo"] + "'";
            CrystalReportViewer1.RefreshReport();
        }
        else
        {
            MessageBox.Show("No records");
            Response.Redirect("~/purreport.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/homemaster.aspx");
    }
}

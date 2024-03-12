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
using System.Windows.Forms;
public partial class purmview : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        try
        {
            c.cmd.CommandText = "select * from porder where month(p_date)='" + (String)Session["m"] + "'and year(p_date)='" + (String)Session["y"] + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "pur");
            if (ds.Tables["pur"].Rows.Count > 0)
            {
                CrystalReportViewer1.SelectionFormula = "month({porder.p_date})=" + (String)Session["m"] + "and year({porder.p_date})=" + (String)Session["y"];
                CrystalReportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No records");
                Response.Redirect("~/purreport.aspx");
            }

        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            c.cnn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/homemaster.aspx");
    }
}

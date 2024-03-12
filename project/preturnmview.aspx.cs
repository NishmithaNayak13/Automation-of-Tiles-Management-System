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
public partial class preturnmview : System.Web.UI.Page
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
            c.cmd .CommandText ="select * from preturn where month(date)='"+(String )Session ["prm"]+"'and year(date)='"+(String )Session ["pry"]+"'";
            adp.SelectCommand =c.cmd ;
            adp.Fill(ds, "ret");
            if (ds.Tables["ret"].Rows.Count > 0)
            {
                CrystalReportViewer1.SelectionFormula = "month({preturn.date})=" + (String)Session["prm"] + "and year({preturn.date})=" + (String)Session["pry"];
                CrystalReportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No records");
                Response.Redirect("~/preturnrepport.aspx");
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
        Response.Redirect("~/preturnyview.aspx");
    }
}

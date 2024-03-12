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

public partial class vieworder : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();

            c.cmd.CommandText = "select * from porder where p_date='"+Session ["da"]+"'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "v");
            if (ds.Tables["v"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["v"];
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record not found')</script>");
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
        try
        {
            c = new connect();
            //dt1 = new DataTable();
            c.cmd.CommandText = "select * from podetails";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "d");
            if (ds.Tables["d"].Rows.Count > 0)
            {
                GridView2.DataSource = ds.Tables["d"];
                GridView2.DataBind();
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
        Response.Redirect("~/porder.aspx");
    }
}

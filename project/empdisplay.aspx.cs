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
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class empdisplay : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();

            c.cmd.CommandText = "select * from employeedetails where status='active'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "emp");
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["emp"];
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record not found')</script>");
                Panel1.Visible = false;
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
            c.cmd.CommandText = "select * from employeedetails where status='inactive'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "emp");
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                GridView2.DataSource = ds.Tables["emp"];
                GridView2.DataBind();
            }
            else
            {
                Panel1.Visible = false;
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
}
    

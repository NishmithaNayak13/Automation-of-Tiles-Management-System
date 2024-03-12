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

public partial class saldisplay : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();

            c.cmd.CommandText = "select * from salary";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sal");
            if (ds.Tables["sal"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["sal"];
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
        
    }
}

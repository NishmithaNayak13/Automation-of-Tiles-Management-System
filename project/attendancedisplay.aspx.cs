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
public partial class attendancedisplay : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from attendance";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "att");
            if (ds.Tables["att"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["att"];
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('No records')</script>");
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
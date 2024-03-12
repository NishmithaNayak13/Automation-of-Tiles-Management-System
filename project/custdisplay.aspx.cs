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

public partial class custdisplay : System.Web.UI.Page
{
    connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from customer";
            //where status='active'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "cust");
            if (ds.Tables["cust"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["cust"];
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
//        try
//        {
//            c = new connect();
//            ds = new DataSet();
//            c.cmd.CommandText = "select * from customer";
//            //where status='inactive'";
//            adp.SelectCommand = c.cmd;
//            adp.Fill(ds, "cust");
//            if (ds.Tables["cust"].Rows.Count > 0)
//            {
//                GridView2.DataSource = ds.Tables["cust"];
//                GridView2.DataBind();
//            }
//            else
//            {
//                Panel1.Visible = false;
//            }
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            c.cnn.Close();
//        }
//    }
//}

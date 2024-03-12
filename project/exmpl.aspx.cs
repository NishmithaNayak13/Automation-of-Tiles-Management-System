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

public partial class exmpl : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
       try
       {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select podetails.item_id,stock.it_name,podetails.tot_no_of_pc from podetails,stock where podetails.item_id=stock.item_id and po_no='"+Session["pppp"]+"'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "d");
            if (ds.Tables["d"].Rows.Count > 0)
            {
                GridView2.DataSource = ds.Tables["d"];
                GridView2.DataBind();
               // Label1.Visible = false;
            }
            else
            {
                MessageBox.Show("no records");
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
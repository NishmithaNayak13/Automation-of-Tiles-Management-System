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

public partial class custupdate : System.Web.UI.Page
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
            if (DropDownList1.Items.Count == 0)
            {
                c.cmd.CommandText = "select distinct(custname) from custdetails";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "c");
                if (ds.Tables["c"].Rows.Count > 0)
                {
                    DropDownList1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["c"].Rows.Count; i++)
                    {
                        DropDownList1.Items.Add(ds.Tables["c"].Rows[i].ItemArray[0].ToString());
                    }
                }
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

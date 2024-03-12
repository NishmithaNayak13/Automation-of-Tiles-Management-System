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

public partial class custsearch : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        if (ddl1.Items.Count == 0)
        {
            c.cmd.CommandText = "select name from customer";
            //where status='active'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "cust");
            if (ds.Tables["cust"].Rows.Count > 0)
            {
                ddl1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["cust"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["cust"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from customer where name='" + ddl1.SelectedItem.ToString() + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "cust");
            if (ddl1.SelectedItem.ToString() != "")
            {
               // if (Convert.ToString(ds.Tables["cust"].Rows[0].ItemArray[5]) != "inactive")
               // {
                    if (ds.Tables["cust"].Rows.Count > 0)
                    {
                        GridView1.DataSource = ds.Tables["cust"];
                        GridView1.DataBind();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('record not found')</script>");
                    }
                //}
                //else
                //{
                //    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('supplier is inactive')</script>");
                //}
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter cust_id')</script>");
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

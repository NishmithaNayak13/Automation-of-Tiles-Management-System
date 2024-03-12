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

public partial class supactivate : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    string lockstatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        if (ddl1.Items.Count == 0)
        {
            c.cmd.CommandText = "select distinct(name) from supplier where  status='inactive'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "s");
            if (ds.Tables["s"].Rows.Count > 0)
            {
                ddl1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["s"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["s"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
    protected void btndisplay_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from supplier where status='active'";
            if (ddl1.SelectedItem.ToString() != "")
            {
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "s");
                if (ds.Tables["s"].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables["s"];
                    GridView1.DataBind();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('No records')</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter sup_id')</script>");
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
    protected void btnactivate_Click(object sender, EventArgs e)
    {
        try
        {
            //string r = "inactive";
            c = new connect();
            ds = new DataSet();
            if (ddl1.SelectedIndex != 0)
            {
                c.cmd.CommandText = "select * from supplier where name='" + ddl1.SelectedItem.Text + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "s");
                if (ds.Tables["s"].Rows.Count > 0)
                {
                    lockstatus = "active";
                    // c.cmd.CommandText = "delete from supplier where name='" + ddl1.SelectedItem.ToString() + "'";
                    // Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record removed')</script>");
                    c.cmd.CommandText = "update supplier set status=@status where name='" + ddl1.SelectedItem.Text + "'";
                    // c.cmd.Parameters.Clear();
                    c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = Convert.ToString(lockstatus);
                    c.cmd.ExecuteNonQuery(); Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Supplier is activated')</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Supplier not found')</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter valid sup_id')</script>");
                ddl1.SelectedIndex = 0;
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





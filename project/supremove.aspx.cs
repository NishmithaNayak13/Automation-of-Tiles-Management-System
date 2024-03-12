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

public partial class supremove : System.Web.UI.Page
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
            c.cmd.CommandText = "select distinct(name) from supplier where  status='active'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sup");
            if (ds.Tables["sup"].Rows.Count > 0)
            {
                ddl1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["sup"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["sup"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            string r = "inactive";
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from supplier where name='" + ddl1.SelectedItem.ToString() + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sup");
            if (ddl1.SelectedIndex != 0)
            {
                if (ds.Tables["sup"].Rows.Count > 0)
                {
                    c.cmd.CommandText = "delete from supplier where name='" + ddl1.SelectedItem.ToString() + "'";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record removed')</script>");
                    c.cmd.CommandText = "update supplier set status=@status where name='" + ddl1.SelectedItem.ToString() + "'";
                    c.cmd.Parameters.Clear();
                    c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = Convert.ToString(r);
                    c.cmd.ExecuteNonQuery();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record does not exists')</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter valid sup_id')</script>");
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
    protected void btndisplay_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from supplier ";
            if (ddl1.SelectedItem.ToString() != "")
            {
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "sup");
                if (ds.Tables["sup"].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables["sup"];
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
}

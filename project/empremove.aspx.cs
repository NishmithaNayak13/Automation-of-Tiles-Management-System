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
public partial class empremove : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        if (DropDownList1.Items.Count == 0)
        {
            c.cmd.CommandText = "select distinct(empname) from employeedetails where status='active'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "emp");
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                DropDownList1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["emp"].Rows.Count; i++)
                {
                    DropDownList1.Items.Add(ds.Tables["emp"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
    protected void btnremove_Click(object sender, EventArgs e)
    {
        try
        {
            String r = "inactive";
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from employeedetails where empname='" + DropDownList1.SelectedItem.ToString() + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "emp");
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                c.cmd.CommandText = "delete from employeedetails where empname='" + DropDownList1.SelectedItem.ToString();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record removed')</script>");
                c.cmd.CommandText = "update employeedetails set status=@status where empname='" + DropDownList1.SelectedItem.ToString() + "'";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = Convert.ToString(r);
                c.cmd.ExecuteNonQuery();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record does not exists')</script>");
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
            c.cmd.CommandText = "select * from employeedetails where status='inactive'";
            if (DropDownList1.SelectedItem.ToString() != "")
            {
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "emp");
                if (ds.Tables["emp"].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables["emp"];
                    GridView1.DataBind();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert(' No Record ')</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter employee no')</script>");
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

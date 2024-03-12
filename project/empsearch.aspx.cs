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

public partial class empsearch : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    DataTable dt1;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            dt1 = new DataTable();
            c.cmd.CommandText = "select distinct(empname) from employeedetails";
            adp.SelectCommand = c.cmd;
            adp.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                DropDownList1.Items.Add(dt1.Rows[i].ItemArray[0].ToString());
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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from employeedetails where empname='" + DropDownList1.SelectedItem.ToString() + "'";
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
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record not found')</script>");
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter emp_id')</script>");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

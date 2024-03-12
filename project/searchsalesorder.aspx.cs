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

public partial class searchsalesorder : System.Web.UI.Page
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
            c.cmd.CommandText = "select distinct(name) from customer";
            adp.SelectCommand = c.cmd;
            adp.Fill(dt1);
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("select");
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DropDownList1.Items.Add(dt1.Rows[i].ItemArray[0].ToString());
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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select customer.cust_id,customer.name,sorder.so_no,sorder.s_date,sorder.due_date from customer,sorder where customer.cust_id=sorder.cust_id and name='"+DropDownList1 .SelectedItem .Text +"'";
       // c.cmd.CommandText = "select * from sorder where so_no='" + DropDownList1.SelectedItem.ToString() + "'";
        if (DropDownList1.SelectedItem.ToString() != "")
        {
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "p");
            if (ds.Tables["p"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["p"];
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record not found')</script>");
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter sup_id')</script>");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/sorder.aspx");
    }
}

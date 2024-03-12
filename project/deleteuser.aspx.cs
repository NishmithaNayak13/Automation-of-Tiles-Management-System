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

public partial class deleteuser : System.Web.UI.Page
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
                c.cmd.CommandText = "select distinct(username) from newlogin";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "reg");
                if (ds.Tables["reg"].Rows.Count > 0)
                {
                    DropDownList1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["reg"].Rows.Count; i++)
                    {
                        DropDownList1.Items.Add(ds.Tables["reg"].Rows[i].ItemArray[0].ToString());
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

    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adminoptions.aspx");
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from newlogin where username='" + DropDownList1.SelectedItem + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "reg");
            if (DropDownList1.SelectedItem.ToString() != "")
            {
                if (ds.Tables["reg"].Rows.Count > 0)
                {
                    c.cmd.CommandText = "delete from newlogin where username='" + DropDownList1.SelectedItem + "'";
                    c.cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record deleted')</script>");
                    DropDownList1.SelectedItem.Text = "";
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record doesnot exist..try another')</script>");
                    DropDownList1.SelectedItem.Text = "";
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter username')</script>");
            }
            Session["user"] = DropDownList1.SelectedItem.Text;
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

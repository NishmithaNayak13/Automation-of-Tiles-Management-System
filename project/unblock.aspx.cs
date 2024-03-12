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

public partial class unblock : System.Web.UI.Page
{
    connect c =new connect();
    DataSet ds = new DataSet();
    //string str;
    SqlDataAdapter adp = new SqlDataAdapter();
    //static string lockstatus;
    protected void Page_Load(object sender, EventArgs e)
    {
      
     
        try
        {
            
            if (DropDownList1.Items.Count == 0)
            {
                c.cmd.CommandText = "select distinct(username) from newlogin where status='locked'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "r1");
                if (ds.Tables["r1"].Rows.Count > 0)
                {
                    DropDownList1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["r1"].Rows.Count; i++)
                    {
                        DropDownList1.Items.Add(ds.Tables["r1"].Rows[i].ItemArray[0].ToString());
                    }
                }
                else
                {
                    Response.Redirect("~/adminoptions.aspx");
                }
            }
            Session["r1"] = DropDownList1.SelectedItem.Text;
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
    //try
    //{
    //    c = new connect();
    //    ds = new DataSet();
    //    str = (string)Request.QueryString[aname];
    //    c.cmd.CommandText = "select sec_qn,sec_ans from newlogin where username='" + str + "'";
    //    adp.SelectCommand = c.cmd;
    //    ds.Clear();
    //    adp.Fill(ds, "Q");
    //    if (ds.Tables["Q"].Rows.Count > 0)
    //    {
    //        lblq.Text = ds.Tables["Q"].Rows[0].ItemArray[3].ToString();
    //    }
    //    else
    //    {
    //        Response.Redirect("~/adminlogin.aspx");
    //    }
    //}
    //catch (Exception ex)
    //{
    //    MessageBox.Show(ex.ToString());
    //}
    //finally
    //{
    //    c.cnn.Close();
    //}


    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adminoptions.aspx");
    }
    protected void btnunblk_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from newlogin where status='locked'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "r");
            if (ds.Tables["r"].Rows.Count > 0)
            {

                string ud = "update newlogin set status='open' where username='" + DropDownList1.SelectedItem + "'";
                c.cmd.CommandText = ud;
                c.cmd.ExecuteNonQuery();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('User account is unlocked')</script>");
                // MessageBox.Show("unblocked");
            }
            else
            {
                MessageBox.Show("account not found");
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
// ds = new DataSet();
//if(ds.Tables ["Q"].Rows [0].ItemArray[4].ToString ().Equals (
//if (txtuser.Text != "")
//{
//    c.cmd.CommandText = "select * from newlogin where username='" + txtuser.Text + "'";
//    adp.SelectCommand = c.cmd;
//    adp.Fill(ds, "reg");
//    if (ds.Tables["reg"].Rows.Count > 0)
//    {
//        lockstatus = "open";
//        c.cmd.CommandText = "update newlogin set status=@status where username='" + txtuser.Text + "'";
//        c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = Convert.ToString(lockstatus);
//        c.cmd.ExecuteNonQuery();
//        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('User account is unlocked')</script>");
//    }
//    else
//    {
//        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('User account not found')</script>");
//        txtuser.Text = "";
//        txtuser.Focus();
//    }
//}
//else
//{
//    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter the user name')</script>");
//    txtuser.Text = "";
//    txtuser.Focus();
//}

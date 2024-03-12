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

public partial class newuserlog : System.Web.UI.Page
{
    connect c = new connect();
    DataSet ds = new DataSet();
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c.cmd.CommandText = "select * from newlogin where  username='" + Session["user"] + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "q");
        if (ds.Tables["q"].Rows.Count > 0)
        {

            Label1.Text = ds.Tables["q"].Rows[0].ItemArray[3].ToString();
        }
    }
    protected void btnbk_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/register.aspx");
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == false)
        {
            txt1.TextMode = TextBoxMode.Password;
            txt2.TextMode = TextBoxMode.Password;
        }
        if (CheckBox1.Checked == true)
        {
            txt1.TextMode = TextBoxMode.SingleLine;
            txt2.TextMode = TextBoxMode.SingleLine;
        }
    }
    protected void txt1_TextChanged(object sender, EventArgs e)
    {
        txt2.Visible = true;
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            //string aa = Session["user"];
            if (txt1.Text != "")
            {
                if (txt1.Text.Length >= 6)
                {
                    if (txt2.Text != "")
                    {
                        c.cmd.CommandText = "update newlogin set password='" + txt2.Text + "' where  username='" + Session["user"] + "'";
                        // DropDownList1.SelectedItem.Text + "'";
                        adp.SelectCommand = c.cmd;
                        adp.Fill(ds, "adreg");
                        c.cmd.CommandText = "update newlogin set sec_ans='" + txta.Text + "'where username='" + Session["user"] + "'";
                        // c.cmd.Parameters.Add("@sec_qn", SqlDbType.VarChar).Value = txtqsn.Text;
                        c.cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txt2.Text;
                        c.cmd.Parameters.Add("@sec_ans", SqlDbType.VarChar).Value = txta.Text;
                        c.cmd.ExecuteNonQuery();
                        Response.Redirect("~/userlogin.aspx");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter confirm password')</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must be atleast 6 characters')</script>");

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
    protected void txt2_TextChanged(object sender, EventArgs e)
    {


    }
}
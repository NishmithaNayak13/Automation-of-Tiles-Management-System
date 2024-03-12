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


public partial class userforgot : System.Web.UI.Page
{
    connect c = new connect();
    DataSet ds = new DataSet();
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList1.Items.Count == 0)
        {
            c.cmd.CommandText = "select distinct(sec_qn) from newlogin ";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "u");
            if (ds.Tables["u"].Rows.Count > 0)
            {
                DropDownList1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["u"].Rows.Count; i++)
                {
                    DropDownList1.Items.Add(ds.Tables["u"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
        Panel2.Visible = false;
        if (IsPostBack)
        {
            String password = txt2.Text;
            txt2.Attributes.Add("value", password);
            string password1 = txt3.Text;
            txt3.Attributes.Add("value", password1);

        }
    }
    protected void btnsub_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "correct answer")
        {
            Panel1.Visible = false;
            Panel2.Visible = true;

        }
        if (txt1.Text == "")
        {
            Label1.Text = "Please enter all fields";
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            string us = Session["user"].ToString();
            if (txt2.Text != "")
            {
                if (txt2.Text.Length >= 6)
                {
                    if (txt3.Text != "")
                    {
                        c.cmd.CommandText = "update newlogin set password='" + txt3.Text + "'where username='"+us+"'";
                        adp.SelectCommand = c.cmd;
                        adp.Fill(ds, "ad");
                        if (txt2.Text == txt3.Text)
                        {
                            Response.Redirect("~/userlogin.aspx");
                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Password must be same')</script>");
                        }
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must enter enter confirm password')</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Must be atleast 6 characters')</script>");
                    Panel2.Visible = true;
                }
            }
            Session["ad"] = DropDownList1.SelectedItem.Text;
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
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        if (CheckBox1.Checked == false)
        {
            txt2.TextMode = TextBoxMode.Password;
            txt3.TextMode = TextBoxMode.Password;
        }
        if (CheckBox1.Checked == true)
        {
            txt2.TextMode = TextBoxMode.SingleLine;
            txt3.TextMode = TextBoxMode.SingleLine;
        }
    }
    protected void txt1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from newlogin where sec_qn='" + DropDownList1.SelectedItem.Text + "'and sec_ans='" + txt1.Text + "'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "m");
            if (ds.Tables["m"].Rows.Count > 0)
            {
                Label1.Text = "Correct answer";
                Panel2.Visible = true;
                Panel1.Visible = false;
            }
            else
            {
                Label1.Text = "Incorrect answer";
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
        Panel2.Visible = true;
    }
}


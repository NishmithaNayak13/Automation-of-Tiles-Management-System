using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class adminlogin : System .Web .UI .Page 
{
    connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        if (IsPostBack)
        {
            String password = txtpass.Text;
            txtpass.Attributes.Add("value", password);
        }
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    string apass=txtpass.ToString ().Trim ();
        //    c.cmd .CommandText ="select * from login where password="+apass +"'";
        //    adp .SelectCommand =c.cmd ;
        //    ds.Clear ();
        //    adp .Fill (ds,"login");
        //    if(ds.Tables ["login"].Rows.Count >0)
        //    {
        //        int count=Convert .ToInt16 (ds.Tables ["login"].Rows [0].ItemArray [1]);
        //        if(count>=3)
        //        {
        //            //Page .RegisterClientScriptBlock ("wp","<script>if(confirm('Your account has been blocked..do you wish to continue?')))
        //            //{

        //            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Your account has been blocked..do you wish to continue?')</script>");
        //        }
        //        else
        //        {
        c = new connect();
        ds = new DataSet();
        ds1 = new DataSet();
        Session["adm"] = Label1.Text;
        if (txtpass.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('please enter password')</script>");
        }
        else
        {
            c.cmd.CommandText = "select * from login where password='" + txtpass.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "adreg");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Login Successful')</script>");
                c.cmd.CommandText = "select * from stock where no_of_pc<reorder";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds1, "stk");
                Response.Redirect("~/adminoptions.aspx");
                if (ds1.Tables["stk"].Rows.Count > 0)
                {
                    Response.Redirect("~/reorder.aspx");
                }
                else
                {
                    Response.Redirect("~/register.aspx");
                }

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Unable to login')</script>");
            }
        }
    }
    //}}


    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == false)
        {
            txtpass.TextMode = TextBoxMode.Password;
        }
        if (CheckBox1.Checked == true)
        {
            txtpass.TextMode = TextBoxMode.SingleLine;
        }
    }
    protected void lnkforgot_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adforgot.aspx");
    }
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/register.aspx");
    }
    protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == false)
        {
            txtpass.TextMode = TextBoxMode.Password;
        }
        if (CheckBox1.Checked == true)
        {
            txtpass.TextMode = TextBoxMode.SingleLine;
        }

    }
    protected void txtpass_TextChanged(object sender, EventArgs e)
    {

    }
}

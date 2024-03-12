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

public partial class adminoptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adduser.aspx");
    }

    protected void btnunblk_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/unblock.aspx");
    }
    protected void btndlt_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/deleteuser.aspx");
    }
    protected void btnexit_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/register.aspx");
    }
    protected void btnemp_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/employee.aspx");
    }
}



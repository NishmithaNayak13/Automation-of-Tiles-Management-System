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

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adminlogin.aspx");
    }
    protected void btnuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/userlogin.aspx");
    }
}
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

public partial class employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btndt_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/homeemp.aspx");
    }
    protected void btnat_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/attendance.aspx");
    }
    protected void btnpay_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/payslip.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/adminoptions.aspx");
    }
}

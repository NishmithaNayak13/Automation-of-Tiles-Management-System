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

public partial class preturnview : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel3.Visible = false;
        DropDownList3.Items.Clear();
        for (int i = 2010; i < DateTime.Today.Year; i++)
        {
            DropDownList3.Items.Add(i.ToString());
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        Panel2.Visible = false;
        DropDownList4.Items.Clear();
        for (int i = 2016; i < DateTime.Today.Year; i++)
        {
            DropDownList4.Items.Add(i.ToString());
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["pry"] = DropDownList3.SelectedItem.Text;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["prm"] = DropDownList2.SelectedValue;
        Session["pry"] = DropDownList3.SelectedItem.Text;
        Response.Redirect("~/preturnmview.aspx");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["prm"] = DropDownList2.SelectedValue;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Session["prye"] = DropDownList4.SelectedItem.Text;
        Response.Redirect("~/preturnyview.aspx");
    }
}

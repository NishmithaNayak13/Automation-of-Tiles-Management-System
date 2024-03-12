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

public partial class report : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select po_no from porder";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "pur");
        if (DropDownList1.Items.Count == 0)
        {
            if (ds.Tables["pur"].Rows.Count > 0)
            {
                DropDownList1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["pur"].Rows.Count; i++)
                {
                    DropDownList1.Items.Add(ds.Tables["pur"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["poo"] = DropDownList1.SelectedItem.Text;
        Response.Redirect("~/purorview.aspx");

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["m"] = DropDownList2.SelectedValue;

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["y"] = DropDownList3.SelectedItem.Text;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["m"] = DropDownList2.SelectedValue;
        Session["y"] = DropDownList3.SelectedItem.Text;
        Response.Redirect("~/purmview.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Session["ye"] = DropDownList4.SelectedItem.Text;
        Response.Redirect("~/puryview.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel1.Visible = false;
        Panel3.Visible = false;
        DropDownList3.Items.Clear();
        for (int i = 2010; i <= DateTime.Today.Year; i++)
        {
            DropDownList3.Items.Add(i.ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel1.Visible = true;
        Panel3.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false; 
        Panel1.Visible = false;
        Panel3.Visible = true;
        DropDownList4.Items.Clear();
        for (int i = 2016; i <= DateTime.Today.Year; i++)
        {
            DropDownList4.Items.Add(i.ToString());
        }
    }
   
}

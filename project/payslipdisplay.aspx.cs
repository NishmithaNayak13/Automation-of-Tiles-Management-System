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
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class payslipdisplay : System.Web.UI.Page
{
   connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();

            c.cmd.CommandText = "select employeedetails.empno,salary.name,salary.edesig,salary.ebasic,salary.presentdays,salary.absentdays,salary.bonus,salary.pf,salary.gross,salary.net from employeedetails,salary where employeedetails.empno=salary.empno and status='active'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "d");
            if (ds.Tables["d"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["d"];
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                Label1 .Visible =true ;
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
    

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/payslip.aspx");
    }
}

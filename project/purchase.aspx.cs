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

public partial class purchase : System .Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnclr_Click(object sender, EventArgs e)
    {
        txtcadd.Text = "";
        txtcno.Text = "";
        txtcont.Text = "";

    }
    protected void btnsub_Click(object sender, EventArgs e)
    {
        connect c = new connect();
        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter();
        try
        {

            c.cmd.CommandText = "insert into customer values(@cname,@address,@phoneno)";
            c.cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = txtcno.Text;
            c.cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtcadd.Text;
            c.cmd.Parameters.Add("@phoneno", SqlDbType.Decimal).Value = Convert.ToInt16(txtcont.Text);
            c.cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            c.cnn.Close();
        }


    }


    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/menu.aspx");
    }
}

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

public partial class img_adduser : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnadd.Enabled = false;
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from newlogin where username='" + txtuser.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "user");
            if (ds.Tables["user"].Rows.Count > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('user already exist')</script>");
            }


            else
            {

                c.cmd.CommandText = "insert into newlogin values(@username,@password,@status,@sec_qn,@sec_ans)";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtuser.Text;
                c.cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = "user";
                c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "open";
                c.cmd.Parameters.Add("@sec_qn", SqlDbType.NVarChar).Value = txtques.Text;
                c.cmd.Parameters.Add("@sec_ans", SqlDbType.NVarChar).Value = "u";
                c.cmd.ExecuteNonQuery();

                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('user added')</script>");
                txtuser.Text = "";
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
    protected void btnb_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adminoptions.aspx");
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        btnadd.Enabled = true;
        if (txtuser.Text == "" || txtques.Text == "")
        {
            Label1.Text = "MUST ENTER ALL THE FEILDS";
        }
    }
}

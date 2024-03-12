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


public partial class custadd : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            int count;
            c.cmd.CommandText = "select count(*) from customer";
            count = Convert.ToInt16(c.cmd.ExecuteScalar()) + 1;
            txtcustid.Text = "CU100" + count.ToString();
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
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            if (txtcustid.Text != "" && txtcustname.Text != "" && txtcustadd.Text != "" && txtcontact.Text != "" && txtemail.Text != "")
            {
                c.cmd.CommandText = "insert into customer values(@cust_id,@name,@address,@contact_no,@email)";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@cust_id", SqlDbType.NVarChar).Value = txtcustid.Text;
                c.cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtcustname.Text;
                c.cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtcustadd.Text;
                c.cmd.Parameters.Add("@contact_no", SqlDbType.NVarChar).Value = txtcontact.Text;
                c.cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtemail.Text;
                //c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "active";
                c.cmd.ExecuteNonQuery();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record Saved')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter all fields')</script>");
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
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtcustname.Text = "";
        txtcustadd.Text = "";
        txtcontact.Text = "";
        txtemail.Text = "";
    }
    protected void txtcontact_TextChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select count(*) from customer where contact_no='" + txtcontact.Text + "'";
            int p = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (p > 0)
            {
                MessageBox.Show("Contact no already exist");
                txtcontact.Text = "";
                txtcontact.Focus();
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
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select count(*) from customer where email='" + txtemail.Text + "'";
            int p = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (p > 0)
            {
                MessageBox.Show("Email already exist");
                txtemail.Text = "";
                txtemail.Focus();
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
    protected void btnneworder_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/sorder.aspx");
    }
}

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
public partial class empupdate : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        txtadd.Focus();
        Panel1.Visible = false;
        if (ddl1.Items.Count == 0)
        {
            c.cmd.CommandText = "select distinct(empname) from employeedetails where status='active'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "emp");
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                ddl1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["emp"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["emp"].Rows[i].ItemArray[0].ToString());
                    //txtid.Text = Convert.ToString(ds.Tables["emp"].Rows[i].ItemArray[0]);
                }
            }
        }
        // Session["emp"] = ddl1.SelectedItem.Text;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from employeedetails where empname='" + ddl1.SelectedItem + "'";
            if (ddl1.SelectedItem.ToString() != "")
            {
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "em");
                if (ds.Tables["em"].Rows.Count > 0)
                //Convert.ToString(
                //.ItemArray[5]) != "inactive")
                {
                    txtid.Text = Convert.ToString(ds.Tables["em"].Rows[0].ItemArray[0]);
                    txtid.Focus();
                    txtadd.Text = Convert.ToString(ds.Tables["em"].Rows[0].ItemArray[2]);
                    txtcon.Text = Convert.ToString(ds.Tables["em"].Rows[0].ItemArray[3]);
                    txtemail.Text = Convert.ToString(ds.Tables["em"].Rows[0].ItemArray[4]);
                    c.cmd.ExecuteNonQuery();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('No records found')</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('must enter cust_id')</script>");
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
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "update employeedetails set address=@address where empname='" + ddl1.SelectedItem.ToString() + "'";
            c.cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtadd.Text;
            c.cmd.ExecuteNonQuery();
            c.cmd.CommandText = "update employeedetails set phno=@phno where empname='" + ddl1.SelectedItem.ToString() + "'";
            c.cmd.Parameters.Add("@phno", SqlDbType.NVarChar).Value = txtcon.Text;
            c.cmd.ExecuteNonQuery();
            c.cmd.CommandText = "update employeedetails set email=@email where empname='" + ddl1.SelectedItem.ToString() + "'";
            c.cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtemail.Text;
            c.cmd.ExecuteNonQuery();
            if (txtid.Text != "" && txtadd.Text != "" && txtcon.Text != "" && txtemail.Text != "")
            {
                c.cmd.ExecuteNonQuery();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record update')</script>");
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
} 
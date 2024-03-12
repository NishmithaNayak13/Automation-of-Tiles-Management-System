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

public partial class custupdate : System.Web.UI.Page
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
            c.cmd.CommandText = "select distinct(name) from customer";
            //supplier where status='active'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "cust");
            if (ds.Tables["cust"].Rows.Count > 0)
            {
                ddl1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["cust"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["cust"].Rows[i].ItemArray[0].ToString());
                    //txtid.Text = Convert.ToString(ds.Tables["sup"].Rows[i].ItemArray[0]);
                }
            }
        }
        //Session["sup"] = ddl1.SelectedItem.Text;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from customer where name='" + ddl1.SelectedItem + "'";
            if (ddl1.SelectedItem.ToString() != "")
            {
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "cust");
                if (ds.Tables["cust"].Rows.Count>0)
                //Convert.ToString(
                //.ItemArray[5]) != "inactive")
                {
                    txtid.Text = Convert.ToString(ds.Tables["cust"].Rows[0].ItemArray[0]);
                    txtid.Focus();
                    txtadd.Text = Convert.ToString(ds.Tables["cust"].Rows[0].ItemArray[2]);
                    txtcon.Text = Convert.ToString(ds.Tables["cust"].Rows[0].ItemArray[3]);
                    txtemail.Text = Convert.ToString(ds.Tables["cust"].Rows[0].ItemArray[4]);
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
            c.cmd.CommandText = "update customer set address=@address where name='" + ddl1.SelectedItem.ToString() + "'";
            c.cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtadd.Text;
            c.cmd.ExecuteNonQuery();
            c.cmd.CommandText = "update customer set contact_no=@contact_no where name='" + ddl1.SelectedItem.ToString() + "'";
            c.cmd.Parameters.Add("@contact_no", SqlDbType.NVarChar).Value = txtcon.Text;
            c.cmd.ExecuteNonQuery();
            c.cmd.CommandText = "update customer set email=@email where name='" + ddl1.SelectedItem.ToString() + "'";
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
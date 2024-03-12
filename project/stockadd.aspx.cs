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


public partial class stockadd : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds=new DataSet ();
            c.cmd.CommandText = "select distinct(cat_id) from category";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds,"s");
            if (ddl1.Items.Count == 0)
            {
                if (ds.Tables["s"].Rows.Count > 0)
                {
                    //ddl1.Items.Add("select");
                    ddl1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["s"].Rows.Count; i++)
                    {
                        ddl1.Items.Add(ds.Tables["s"].Rows[i].ItemArray[0].ToString());
                    }
                }
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
    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from category where cat_id='" + ddl1.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "st");
            if (ds.Tables["st"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["st"].Rows.Count; i++)
                {
                    Label1.Text = Convert.ToString(ds.Tables["st"].Rows[i].ItemArray[1]);

                }
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
        try
        {
            c = new connect();
            ds = new DataSet();
            if (ddl1.SelectedIndex ==0 || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter all the feilds')</script>");
            }
            else
            {
                c.cmd.CommandText = "insert into stock values (@cat_id,@item_id,@hsn,@it_name,@price,@selling_price,@pc_per_box,@no_of_box,@reorder)";
                c.cmd.Parameters.Add("@cat_id", SqlDbType.NVarChar).Value = ddl1.SelectedItem.ToString();
                c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = TextBox1.Text;
                c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = TextBox7.Text;
                c.cmd.Parameters.Add("@hsn", SqlDbType.NVarChar).Value = TextBox2.Text;
                c.cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(TextBox3.Text);
                c.cmd.Parameters.Add("@selling_price", SqlDbType.Decimal).Value = "0";
                c.cmd.Parameters.Add("pc_per_box", SqlDbType.SmallInt).Value = Convert.ToInt16(TextBox4.Text);
                c.cmd.Parameters.Add("no_of_box", SqlDbType.SmallInt).Value = Convert.ToInt16(TextBox5.Text);
                c.cmd.Parameters.Add("reorder", SqlDbType.BigInt).Value = Convert.ToInt32(TextBox6.Text);
                c.cmd.ExecuteNonQuery();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('item added to the stock')</script>");
                ddl1.SelectedIndex = 0;
                Label1.Text = "";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
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
    protected void Button2_Click(object sender, EventArgs e)
    {

        ddl1.SelectedIndex = 0;
        Label1.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        if(!System .Text.RegularExpressions .Regex .IsMatch (TextBox3 .Text,"^[0-9]"))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('only numeric value')</script>");
            //MessageBox .Show ("only numeric value");
            TextBox3 .Text.Remove (TextBox3 .Text .Length-1 );
            TextBox3 .Text ="";
        }
    }
    
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select count(*) from stock where it_name='" + TextBox2.Text + "'";
            int p = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (p > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Item already exist')</script>");
                TextBox2.Text = "";
                TextBox2.Focus();
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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select count(*) from stock where item_id='" + TextBox2.Text + "'";
            int p = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (p > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Item ID already exist')</script>");
                TextBox2.Text = "";
                TextBox2.Focus();
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
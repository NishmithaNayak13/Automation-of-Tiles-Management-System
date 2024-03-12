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

public partial class e : System.Web.UI.Page
{
 connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
       
        if (!IsPostBack)
        {
            try
            {
                //int count;
                //txt3.Text = DateTime.Now.ToShortDateString();
                //c.cmd.CommandText = "select count(*) from purbill";
                //count = Convert.ToInt16(c.cmd.ExecuteScalar()) + 1;
                //txt1.Text = "B100" + count.ToString();
                //if (ddl1.Items.Count == 0)
                //{
                    c.cmd.CommandText = "select distinct(po_no) from porder";
                    adp.SelectCommand = c.cmd;
                    adp.Fill(ds, "o");
                    if (ds.Tables["o"].Rows.Count > 0)
                    {
                        ddl1.Items.Add("select");
                        int i;
                        for (i = 0; i < ds.Tables["o"].Rows.Count; i++)
                        {
                            ddl1.Items.Add(ds.Tables["o"].Rows[i].ItemArray[0].ToString());
                        }
                    }
                //}
                Session["pppp"] = ddl1.SelectedItem.Text;
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
    
protected void  Button1_Click(object sender, EventArgs e)
{
    Response .Redirect ("~/exmpl.aspx");
}
    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();

            c.cmd.CommandText = "select * from podetails where po_no='" + ddl1.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "po");
            if (ds.Tables["po"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["po"].Rows.Count; i++)
                {
                    ddl2.Items.Add(Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[1]));
                    //txt6.Text  = Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[2]);
                }

            }
            else
            {
                MessageBox.Show("no records found ");
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


    

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


public partial class porder : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
       // Button7.Enabled = true;
       // Button3.Visible = false;
       // Button4.Visible = false;
       // Button5.Visible = false;
       // Button6.Visible = false;
       // Panel3.Visible = false;

        try
        {
            MaintainScrollPositionOnPostBack = true;
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select distinct(cat_id) from stock";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "cc");
            if (ddl2.Items.Count == 0)
            {
                if (ds.Tables["cc"].Rows.Count > 0)
                {

                    ddl2.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["cc"].Rows.Count; i++)
                    {
                        ddl2.Items.Add(ds.Tables["cc"].Rows[i].ItemArray[0].ToString());
                    }
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select distinct(name) from supplier";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "c");
            if (ddl1.Items.Count == 0)
            {
                if (ds.Tables["c"].Rows.Count > 0)
                {

                    ddl1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["c"].Rows.Count; i++)
                    {
                        ddl1.Items.Add(ds.Tables["c"].Rows[i].ItemArray[0].ToString());
                    }
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
        c = new connect();
        ds = new DataSet();
        if (!IsPostBack)
        {
            try
            {
                Calendar1.Visible = false;
                int count;
                TextBox2.Text = DateTime.Now.ToShortDateString();
                c.cmd.CommandText = "select count(*) from porder";
                count = Convert.ToInt16(c.cmd.ExecuteScalar()) + 1;
                TextBox1.Text = "P100" + count.ToString();
                if ((string)Session["nextpr"] == "yes")
                {
                    TextBox1.Text = (string)Session["pono"];
                    TextBox2.Text = (string)Session["odate"];
                    TextBox3.Text = (string)Session["ddate"];
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTime dt1 = DateTime.Now;
        DateTime dt2 = Convert.ToDateTime(Calendar1.SelectedDate.ToString());
        DateTime dt3 = DateTime.Now.AddDays(15);
        if (dt2 <= dt1)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('we cannot select date')</script>");
        }
        else if (dt2 > dt3)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Due date must be within 15 days')</script>");
        }
        else
        {
            TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        if (TextBox3.Text == "")
        {
            Calendar1.Visible = true;
        }
        else
        {
            Calendar1.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button3.Visible = true;
        Button4.Visible = true;
        Button5.Visible = true;
        Button6.Visible = true;

        try
        {
            if (TextBox4.Text == "" || ddl2.SelectedIndex == 0 || ddl3.SelectedIndex == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('ENTER ALL FIELDS!!!')</script>");
            }
            else 
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("item_id");
                dt.Columns.Add("HSN");
                dt.Columns.Add("i_name");
                dt.Columns.Add("tot_no_of_pc");
                DataRow dr = null;
                if (ViewState["porder"] != null)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        dt = (DataTable)ViewState["porder"];
                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.NewRow();
                            dr["item_id"] = Label2.Text;
                            dr["HSN"] = Label3.Text;
                            dr["i_name"] = ddl3.SelectedItem.Text;
                            dr["tot_no_of_pc"] = TextBox4.Text;
                            dt.Rows.Add(dr);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }

                else
                {
                    dr = dt.NewRow();
                    dr["item_id"] = Label2.Text;
                    dr["HSN"] = Label3.Text;
                    dr["i_name"] = ddl3.SelectedItem.Text;
                    dr["tot_no_of_pc"] = TextBox4.Text;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }

                ViewState["porder"] = dt;
                //c.cmd.CommandText = "insert into podetails values (@po_no,@item_id,@tot_no_of_pc)";
                //c.cmd.Parameters.Add("@po_no", SqlDbType.NVarChar).Value = TextBox1.Text;
                //c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = Label2.Text;
                //c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(TextBox4.Text);
                //c.cmd.ExecuteNonQuery();
                c.cmd.CommandText = "select item_id from podetails where po_no='" + TextBox1.Text +"'and item_id='" + Label2.Text +"'"; 
                int p = Convert.ToInt16(c.cmd.ExecuteScalar());
                if (p > 0)
                {
                    //if (Convert.ToString (p) == Label2.Text)
                    //{
                        c.cmd.CommandText = "select tot_no_of_pc from podetails where item_id='" + Label2.Text + "'and po_no='" + TextBox1.Text + "'";
                        adp.SelectCommand = c.cmd;
                        adp.Fill(ds, "s");
                        for (int i = 0; i < ds.Tables["s"].Rows.Count; i++)
                        {
                            //MessageBox.Show("item already ordered");
                            int y1 = Convert.ToInt16(ds.Tables["s"].Rows[i].ItemArray[0]);
                            int y2 = y1 + Convert.ToInt16(TextBox4.Text);
                            c.cmd.CommandText = "update podetails set tot_no_of_pc=@tot_no_of_pc where item_id='" + Label2.Text + "'";
                            c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = y2;
                            c.cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        c.cmd.CommandText = "insert into podetails values (@po_no,@item_id,@tot_no_of_pc)";
                        c.cmd.Parameters.Add("@po_no", SqlDbType.NVarChar).Value = TextBox1.Text;
                        c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = Label2.Text;
                        c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(TextBox4.Text);
                        c.cmd.ExecuteNonQuery();
                    }
                //}
                Session["pono"] = TextBox1.Text;
                Session["iid"] = Label2.Text;
                Session["qty"] = TextBox4.Text;
                Session["HSN"] = Label3.Text;
                ddl2.SelectedIndex = 0;
                ddl3.SelectedIndex = 0;
                Label2.Text = "";
                TextBox4.Text = "";
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
    //protected void  GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //}
    //protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from supplier where name='" + ddl1.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sp");
            if (ds.Tables["sp"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["sp"].Rows.Count; i++)
                {
                    Label1.Text = Convert.ToString(ds.Tables["sp"].Rows[i].ItemArray[0]);

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
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            
            c = new connect();
            if (TextBox3.Text == "" || ddl1.SelectedIndex == 0)
            {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('ENTER ALL FIELDS!!!')</script>");
            }
            else
            {
                c.cmd.CommandText = "insert into porder values (@po_no,@p_date,@sup_id,@due_date,@status)";
                c.cmd.Parameters.Add("@po_no", SqlDbType.NVarChar).Value = TextBox1.Text;
                c.cmd.Parameters.Add("@p_date", SqlDbType.DateTime).Value = Convert.ToDateTime(TextBox2.Text);
                c.cmd.Parameters.Add("@sup_id", SqlDbType.NVarChar).Value = Label1.Text;
                c.cmd.Parameters.Add("@due_date", SqlDbType.DateTime).Value = Convert.ToDateTime(TextBox3.Text);
                c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "unpaid";
                c.cmd.ExecuteNonQuery();

                Session["pono"] = TextBox1.Text;
                Session["odate"] = TextBox2.Text;
                Session["sid"] = Label1.Text;
                Session["ddate"] = TextBox3.Text;

                Button3.Visible = true;
                Button4.Visible = true;
                Button5.Visible = true;
                Button3.Enabled = true;
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                Button7.Enabled = false;
                Session["da"] = TextBox2.Text;
                Session["oo"] = TextBox1.Text;
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
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/vieworder.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        try
        {
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('order placed')</script>");
            MessageBox.Show("order placed");
            Response.Redirect("~/homemaster.aspx");
            Button7.Enabled = true;
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            ddl1.SelectedIndex = 0;
            Label1.Text = "";
           // Panel3.Visible = false;
            //Panel2.Visible = false;


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
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
    {
        try
        {

            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from stock where cat_id='" + ddl2.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "pa");
            if (ddl3.Items.Count == 0)
            {
                if (ds.Tables["pa"].Rows.Count > 0)
                {
                    ddl3.Items.Add("select");
                    for (int i = 0; i < ds.Tables["pa"].Rows.Count; i++)
                    {
                        ddl3.Items.Add(Convert.ToString(ds.Tables["pa"].Rows[i].ItemArray[3]));

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
    protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
    {
        try
        {

            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from stock where it_name='" + ddl3.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "it");
            if (ds.Tables["it"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["it"].Rows.Count; i++)
                {
                    Label3.Text = Convert.ToString(ds.Tables["it"].Rows[i].ItemArray[2]);
                    Label2.Text = Convert.ToString(ds.Tables["it"].Rows[i].ItemArray[1]);

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
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/searchorder.aspx");
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
   
}

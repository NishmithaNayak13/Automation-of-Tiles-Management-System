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

public partial class purrbill : System.Web.UI.Page
{
    connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    SqlDataAdapter adp1 = new SqlDataAdapter();
    DataTable dt = new DataTable();
    string billno = "BILLNO";
    string slno = "SLNO";
    double p, tp, gt = 0, grand, gra;
    int q;
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        MaintainScrollPositionOnPostBack = true;
        Calendar1.Visible = false;
        Calendar2.Visible = false;
        Panel1.Visible = false;
        Panel2.Visible = false;
         Panel6.Visible = false;
        // btnhome.Visible = false;
        btnnext.Visible = false;
        btnreject.Visible = false;
        btnsave.Visible = false;
        DateTime dt = System.DateTime.Now;
        Label2.Text = Convert.ToString(dt.Date);
        txtbilldate.Text = Convert.ToString(dt.Date.ToShortDateString());

        c = new connect();
        c.cmd.CommandText = "select po_no from porder where status='unpaid'";
        ds = new DataSet();
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "sup");
        {
            if (ddlorderno.Items.Count == 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlorderno.Items.Add("select");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        id = Convert.ToString(ds.Tables[0].Rows[i]["po_no"]);
                        ddlorderno.Items.Add(id.ToString());
                    }
                }
            }
        }
    }
    protected void btnnew_Click(object sender, EventArgs e)
    {
        c = new connect();
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        if (IsPostBack)
        {
            c.cmd.CommandText = "select count(*) from purbill";
            int i = Convert.ToInt16(c.cmd.ExecuteScalar());
            i++;
            txtbillno.Text = billno + i.ToString();
        }
        if (IsPostBack)
        {
            c.cmd.CommandText = "select count(*) from preturn";
            int i = Convert.ToInt16(c.cmd.ExecuteScalar());
            i++;
            txtslno.Text = slno + i.ToString();
        }
        btnhome.Visible = true;
        btnnext.Visible = true;
        string ret = "RET";
        Panel6.Visible = true;
        DateTime dt1 = System.DateTime.Now;
        txtdate.Text = Convert.ToString(dt1.Date.ToShortDateString());
        txtbill.Text = txtbillno.Text;
        c = new connect();
        if (IsPostBack)
        {
            c.cmd.CommandText = "select count(*) from preturn";
            int i = Convert.ToInt16(c.cmd.ExecuteScalar());
            i++;
            txtret.Text = ret + i.ToString();
        }

    }
    protected void ddlproid_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        try
        {
            c = new connect();
            ds = new DataSet();
            ds1 = new DataSet();
            //txtprice.Text = "";
            //txttotal.Text = "";
            c.cmd.CommandText = "select * from podetails where po_no='" + ddlorderno.SelectedItem.Text + "'and item_id='" + ddlproid.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "pur");

            if (ds.Tables["pur"].Rows.Count > 0)
            {
                c.cmd.CommandText = "select * from stock where item_id='" + ddlproid.SelectedItem.Text + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds1, "t");
                if (ds1.Tables["t"].Rows.Count > 0)
                {

                    txtqty.Text = Convert.ToString(ds.Tables["pur"].Rows[0].ItemArray[2]);
                    //txtprice.Text = Convert.ToString(ds1.Tables["t"].Rows[0].ItemArray[4]);
                    txtname.Text = Convert.ToString(ds1.Tables["t"].Rows[0].ItemArray[3]);
                }
                else
                {
                    MessageBox.Show("no records found11111 ");
                }
            }
            //else
            //{
            //    MessageBox.Show("no records found 22222");
            //}
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
        GridView1.Visible = false;
        btnnext.Enabled = false;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('BILL ACCEPTED')</script>");
    }
    protected void btnhome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/homemaster.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtbilldate.Text = "";
        txtbillno.Text = "";
        txtsid.Text = "";
        txtrdate.Text = "";
        txttotal.Text = "";
        txtgtotal.Text = "";
        txtqty.Text = "";
        txtprice.Text = "";
        txtqa.Text = "";
        txtqr.Text = "";
        ddlorderno.SelectedIndex = 0;
        txtorderdate.Text = "";
        ddlproid.SelectedIndex = 0;

    }
    protected void ddlorderno_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from porder where po_no='" + ddlorderno.SelectedItem.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "pur");
        if (ds.Tables["pur"].Rows.Count > 0)
        {
            ddlorderno.SelectedItem.Text = Convert.ToString(ds.Tables["pur"].Rows[0].ItemArray[0]);
            txtorderdate.Text = Convert.ToString(ds.Tables["pur"].Rows[0].ItemArray[1]);
            txtsid.Text = Convert.ToString(ds.Tables["pur"].Rows[0].ItemArray[2]);
        }
        c.cmd.CommandText = "select item_id from podetails where po_no='" + ddlorderno.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "pur");
        {
            if (ddlproid.Items.Count == 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlproid.Items.Add("select");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        id = Convert.ToString(ds.Tables[0].Rows[i]["item_id"]);
                        ddlproid.Items.Add(id.ToString());
                    }
                }
            }
        }
    }
    protected void txtprice_TextChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        Double i = Convert.ToDouble(txtprice.Text);
        decimal up = Convert.ToDecimal(5.0 + i);
        txtsp.Text = Convert.ToString(up);
    }
    protected void txtqa_TextChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        p = Convert.ToDouble(txtprice.Text);
        q = Convert.ToInt16(txtqa.Text);
        tp = Convert.ToDouble(p * q);
        txttotal.Text = Convert.ToString(tp);
        c = new connect();
        c.cmd.CommandText = "select * from purbill where bill_no='" + txtbillno.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "bill");
        if (ds.Tables["bill"].Rows.Count > 0)
        {
            grand = Convert.ToDouble(ds.Tables["bill"].Rows[0].ItemArray[4]);
        }
        gt = grand + (Convert.ToDouble(txttotal.Text));
        txtgtotal.Text = (Convert.ToString(gt));
        double t = Convert.ToDouble(txtqr.Text);
        int s = Convert.ToInt16(txtqa.Text);
        double r = Convert.ToDouble(t - s);
        txtrej.Text = Convert.ToString(r);
    }
    protected void btnreject_Click(object sender, EventArgs e)
    {
        btnsave.Visible = true;
        Panel6.Visible = true;
        try
        {
            c = new connect();

            c.cmd.CommandText = "select distinct preturn.slno,preturn.preturnno,purbill.bill_no,preturn.date,preturn.tot_no_of_pc,preturn.gtot,preturn.price from purbill,preturn where purbill.bill_no=preturn.bill_no and preturnno='" + txtret.Text + "'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "d");
            if (ds.Tables["d"].Rows.Count > 0)
            {
                GridView3.DataSource = ds.Tables["d"];
                GridView3.DataBind();
                // Label1.Visible = false;
            }
            else
            {
                MessageBox.Show("...");
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
    protected void btnret_Click(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "update preturn set gtot='" + txtt.Text + "' where bill_no='" + txtbill.Text + "'";
        c.cmd.ExecuteNonQuery();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Returned')</script>");
    }
    protected void btnnext_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Visible = true;
        btnreject.Visible = true;
        try
        {
            if (txtsbno.Text == "" || txtsbdate.Text == "" || ddlorderno.SelectedIndex == 0 || ddlproid.SelectedIndex == 0 || txtprice.Text == "" || txtrdate.Text == "" || txtqr.Text == "" || txtqa.Text == "" || txtgst.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter all fields')</script>");
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("bill_no");
                dt.Columns.Add("item_id");
                dt.Columns.Add("item_name");
                dt.Columns.Add("quantity");
                dt.Columns.Add("amt");
                dt.Columns.Add("price");
                DataRow dr = null;
                if (ViewState["pbill"] != null)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        dt = (DataTable)ViewState["pbill"];
                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.NewRow();
                            dr["bill_no"] = txtbillno.Text;
                            dr["item_id"] = ddlproid.SelectedItem.Text;
                            dr["item_name"] = txtname.Text;
                            dr["quantity"] = txtqa.Text;
                            dr["amt"] = txtprice.Text;
                            dr["price"] = txttotal.Text;
                            dt.Rows.Add(dr);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
                else
                {
                    dr = dt.NewRow();
                    dr["bill_no"] = txtbillno.Text;
                    dr["item_id"] = ddlproid.SelectedItem.Text;
                    dr["item_name"] = txtname.Text;
                    dr["quantity"] = txtqa.Text;
                    dr["amt"] = txtprice.Text;
                    dr["price"] = txttotal.Text;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                ViewState["pbill"] = dt;
                c = new connect();
                ds = new DataSet();
                int qty1, qty2;
                if (txtprice.Text != "")
                {
                    c.cmd.CommandText = "select * from purbill where bill_no='" + txtbillno.Text + "'";
                    adp.SelectCommand = c.cmd;
                    ds = new DataSet();
                    adp.Fill(ds, "pur");
                    if (ds.Tables["pur"].Rows.Count > 0)
                    {
                        c.cmd.CommandText = "update purbill set bill_no='" + txtbillno.Text + "'," + "po_no='" + ddlorderno.SelectedItem.Text + "'," + "s_billno='" + txtsbno.Text + "'," + "p_date='" + txtsbdate.Text + "'," + "gtot='" + txtgtotal.Text + "'" + " where bill_no='" + txtbillno.Text + "'";
                        c.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        c.cmd.CommandText = "insert into purbill values(@bill_no,@po_no,@p_date,@s_billno,@gtot)";
                        c.cmd.Parameters.Clear();
                        c.cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
                        c.cmd.Parameters.Add("@po_no", SqlDbType.NVarChar).Value = ddlorderno.SelectedItem.Text;
                        c.cmd.Parameters.Add("@p_date", SqlDbType.DateTime).Value = txtsbdate.Text;
                        c.cmd.Parameters.Add("@s_billno", SqlDbType.NVarChar).Value = txtsbno.Text;
                        c.cmd.Parameters.Add("@gtot", SqlDbType.Decimal).Value = Convert.ToDecimal(txtgtotal.Text);
                        c.cmd.ExecuteNonQuery();
                    }
                    c.cmd.CommandText = "insert into pbdetails values(@bill_no,@item_id,@amt,@no_of_pc,@price)";
                    c.cmd.Parameters.Clear();
                    c.cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
                    c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = ddlproid.Text;
                    c.cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Convert.ToDecimal(txtprice.Text);
                    c.cmd.Parameters.Add("@no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(txtqa.Text);
                    c.cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txttotal.Text);
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "update porder set status='paid' where po_no='" + ddlorderno.SelectedItem.Text + "'";
                    c.cmd.ExecuteNonQuery();
                    Session["billno"] = txtbillno.Text;
                }
                c.cmd.CommandText = "select no_of_box from stock where item_id='" + ddlproid.SelectedItem.ToString() + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "stk");
                if (ds.Tables["stk"].Rows.Count > 0)
                {
                    qty1 = Convert.ToInt16(ds.Tables["stk"].Rows[0].ItemArray[0]);
                    qty2 = qty1 + Convert.ToInt16(txtqty.Text);
                    c.cmd.CommandText = "update stock set no_of_box=@no_of_box where item_id='" + ddlproid.SelectedItem.ToString() + "'";
                    c.cmd.Parameters.Add("@no_of_box", SqlDbType.SmallInt).Value = qty2;
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "update stock set selling_price=@selling_price where item_id='" + ddlproid.SelectedItem.ToString() + "'";
                    c.cmd.Parameters.Add("@selling_price", SqlDbType.SmallInt).Value = Convert.ToInt16(txtsp.Text);
                    c.cmd.ExecuteNonQuery();
                    ddlproid.SelectedItem.Enabled = false;
                }
                c.cmd.CommandText = "insert into preturn values(@slno,@preturnno,@ibill_no,@date,@tot_no_of_pc,@gtot,@iprice)";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@slno", SqlDbType.NVarChar).Value = txtslno.Text;
                c.cmd.Parameters.Add("@preturnno", SqlDbType.NVarChar).Value = txtret.Text;
                c.cmd.Parameters.Add("@ibill_no", SqlDbType.NVarChar).Value = txtbill.Text;
                c.cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(txtdate.Text);
                c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(txtrej.Text);
                c.cmd.Parameters.Add("@gtot", SqlDbType.Decimal).Value = 0.0;
                c.cmd.Parameters.Add("@iprice", SqlDbType.Decimal).Value = Convert.ToDecimal(TextBox1.Text);
                c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "select count(*) from preturn";
                    int k = Convert.ToInt16(c.cmd.ExecuteScalar());
                    k++;
                    txtslno.Text = slno + k.ToString();
                    txtt.Text = "0";
                    c = new connect();
                    c.cmd.CommandText = "select * from preturn where bill_no='" + txtbillno.Text + "'";
                    adp.SelectCommand = c.cmd;
                    adp.Fill(ds, "rr");
                    if (ds.Tables["rr"].Rows.Count > 0)
                    {
                        gra = Convert.ToDouble(ds.Tables["rr"].Rows[0].ItemArray[4]);
                    }
                    Double rt = gra + (Convert.ToDouble(TextBox1.Text));
                    txtt.Text = (Convert.ToString(rt));
                    c.cmd.CommandText = "update preturn set gtot='" + txtt.Text + "' where bill_no='" + txtbill.Text + "'";
                    c.cmd.ExecuteNonQuery();
            }
            txtname.Text = "";
            txtqty.Text = "";
            txtsp.Text = "";
            txtqr.Text = "";
            txtqa.Text = "";
            txttotal.Text = "";
            txtgtotal.Text = "";
            txtrej.Text = "";
            txtgst.Text = "";
            txtgrandtotal.Text = "";
            txtprice.Text = "";
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        Calendar1.Visible = true;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        Calendar2.Visible = true;
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        txtrdate.Text = Calendar2.SelectedDate.ToString();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        txtsbdate.Text = Calendar1.SelectedDate.ToString();
    }
    protected void txtqr_TextChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        double y = Convert.ToDouble(txtqty.Text);
        double z = Convert.ToDouble(txtqr.Text);
        if (z > y)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Quantity recieved should be less than quantity')</script>");
            txtqr.Text = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
        double a = Convert.ToDouble(txtgtotal.Text);
        double b = Convert.ToDouble(txtgst.Text);
        double j = (b * a / 100) + a;
        txtgrandtotal.Text = Convert.ToString(j);
        double u = Convert.ToDouble(txtprice.Text);
        int o = Convert.ToInt16(txtrej.Text);
        double qu = Convert.ToDouble(u * o);
        TextBox1.Text = Convert.ToString(qu);
        double du = Convert.ToDouble(u * o);
        txtt.Text = Convert.ToString(du);
    }
    protected void txtsbno_TextChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
    }
    protected void txtgst_TextChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
    }
    protected void txtsbno_TextChanged1(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        btnnext.Enabled = true;
        btnnext.Visible = true;
    }
}
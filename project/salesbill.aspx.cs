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
public partial class salesbill : System.Web.UI.Page
{
    connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    SqlDataAdapter adp1 = new SqlDataAdapter();
    DataTable dt = new DataTable();
    string billno = "BILLNO";
    double p, tp, gt = 0, grand,r;
    int q;
    string id;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        MaintainScrollPositionOnPostBack = true;
        //Panel1.Visible = false;
     //   Panel2.Visible = false;
        ddlorderno.Enabled = true;
        DateTime dt = System.DateTime.Now;
        Label2.Text = Convert.ToString(dt.Date);
        txtbilldate.Text = Convert.ToString(dt.Date.ToShortDateString());
        //btnhome.Visible = false;
       // btnnext.Visible = false;
        c = new connect();
        c.cmd.CommandText = "select so_no from sorder where status='unpaid'";
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
                        id = Convert.ToString(ds.Tables[0].Rows[i]["so_no"]);
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
        if (IsPostBack)
        {
            c.cmd.CommandText = "select count(*) from salesbill";
            int i = Convert.ToInt16(c.cmd.ExecuteScalar());
            i++;
            txtbillno.Text = billno + i.ToString();
        }
        btnhome.Visible = true;
        btnnext.Visible = true;

    }
    protected void ddlproid_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            ds1 = new DataSet();
            txtprice.Text = "";
            txttotal.Text = "";
            c.cmd.CommandText = "select * from sodetails where so_no='" + ddlorderno.SelectedItem.Text + "'and item_id='" + ddlproid.SelectedItem.Text + "'";
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
                    txtprice.Text = Convert.ToString(ds1.Tables["t"].Rows[0].ItemArray[5]);
                    txtitname.Text = Convert.ToString(ds1.Tables["t"].Rows[0].ItemArray[3]);
                }
                else
                {
                    MessageBox.Show("no records found ");
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
    protected void btnsave_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('DONE')</script>");
    //    c = new connect();
    //    ds = new DataSet();
    //    int qty1, qty2;
    //    c.cmd.CommandText = "insert into sbdetails values(@sbill_no,@item_id,@amt,@no_of_pc,@price)";
    //    c.cmd.Parameters.Clear();
    //    if (txtprice.Text != "")
    //    {
    //        c.cmd.Parameters.Add("@sbill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
    //        c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = ddlproid.Text;
    //        c.cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Convert.ToDecimal(txtprice.Text);
    //        c.cmd.Parameters.Add("@no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(txtqty.Text);
    //        c.cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txttotal.Text);
    //        c.cmd.ExecuteNonQuery();
    //        c.cmd.CommandText = "update sorder set status='paid' where so_no='" + ddlorderno.SelectedItem.Text+"'";
    //        c.cmd.ExecuteNonQuery();
    //        Session["billno"] = txtbillno.Text;
    //        c.cmd.CommandText = "select * from salesbill where sbill_no='" + txtbillno.Text + "'";
    //        adp.SelectCommand = c.cmd;
    //        ds = new DataSet();
    //        adp.Fill(ds, "pur");
    //        if (ds.Tables["pur"].Rows.Count > 0)
    //        {
    //            c.cmd.CommandText = "update salesbill set sbill_no='" + txtbillno.Text + "'," + "so_no='" + ddlorderno.SelectedItem.Text + "'," + "s_date='" + txtorderdate.Text + "'," + "p_mode='" + ddlpmode.SelectedItem.Text + "'," + "gtot='" + txtgtotal.Text + "'," + "discount='" +txtdiscount .Text +"'" + " where bill_no='" + txtbillno.Text + "'";
    //            c.cmd.ExecuteNonQuery();
                
    //        }
    //        else
    //        {
    //            c.cmd.CommandText = "insert into salesbill values(@sbill_no,@so_no,@s_date,@p_mode,@gtot,@discount)";
    //            c.cmd.Parameters.Clear();
    //            c.cmd.Parameters.Add("@sbill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
    //            c.cmd.Parameters.Add("@so_no", SqlDbType.NVarChar).Value = ddlorderno.SelectedItem.Text;
    //            c.cmd.Parameters.Add("@s_date", SqlDbType.DateTime).Value = txtbilldate.Text;
    //            c.cmd.Parameters.Add("@p_mode", SqlDbType.NVarChar).Value = ddlpmode.SelectedItem.Text;
    //            c.cmd.Parameters.Add("@gtot", SqlDbType.Decimal).Value = Convert.ToDecimal(txtgtotal.Text);
    //            c.cmd.Parameters.Add("@discount", SqlDbType.SmallInt).Value = Convert.ToInt16(txtdiscount.Text);
    //            c.cmd.ExecuteNonQuery();
    //        }
    //        Session["gtotal"] = txtgtotal.Text;
    //        c.cmd.CommandText = "select no_of_box from stock where item_id='" + ddlproid.SelectedItem.ToString() + "'";
    //        adp.SelectCommand = c.cmd;
    //        adp.Fill(ds, "stk");
    //        if (ds.Tables["stk"].Rows.Count > 0)
    //        {
    //            qty1 = Convert.ToInt16(ds.Tables["stk"].Rows[0].ItemArray[0]);
    //            qty2 = qty1 - Convert.ToInt16(txtqty.Text);
    //            c.cmd.CommandText = "update stock set no_of_box=@no_of_box where item_id='" + ddlproid.SelectedItem.ToString() + "'";
    //            c.cmd.Parameters.Add("@no_of_box", SqlDbType.SmallInt).Value = qty2;
    //            c.cmd.ExecuteNonQuery();
    //            MessageBox.Show("records inserted");
    //            ddlproid.SelectedItem.Enabled = false;
    //            ddlproid.SelectedIndex = 0;
    //            txtqty.Text = "";
    //            txttotal.Text = "";
    //            txtprice.Text = "";
    //            //txtqr.Text = "";
    //            //txtqa.Text = "";
    //            txtgtotal.Text = "";
    //            c.cmd.CommandText = "select * from salesbill where sbill_no='" + Session["billno"] + "'";
    //            ds = new DataSet();
    //            adp.Fill(ds, "sales");
    //            if (ds.Tables["sales"].Rows.Count > 0)
    //            {
    //                GridView1.DataSource = ds.Tables["sales"];
    //                GridView1.DataBind();
    //            }
    //            c.cmd.CommandText = "select * from sbdetails where sbill_no='" + Session["billno"] + "'";
    //            ds = new DataSet();
    //            adp.Fill(ds, "sales");
    //            if (ds.Tables["sales"].Rows.Count > 0)
    //            {
    //                GridView2.DataSource = ds.Tables["sales"];
    //                GridView2.DataBind();
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("no records found ");
    //        }
    //    }
    //    else
    //    {
    //        MessageBox.Show("must enter price");
    //    }
    //    //Session["qr"] = txtrej.Text;
    //    Session["q"] = txtqty.Text;
    }
    protected void btnhome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/homemaster.aspx");
    }
    //protected void btncancel_Click(object sender, EventArgs e)
    //{
    //    txtbilldate.Text = "";
    //    txtbillno.Text = "";
    //   // txtsid.Text = "";
    //    //txtrdate.Text = "";
    //    txttotal.Text = "";
    //    txtgtotal.Text = "";
    //    txtqty.Text = "";
    //    txtprice.Text = "";
    //    //txtqa.Text = "";
    //   // txtqr.Text = "";
    //}
    protected void ddlorderno_SelectedIndexChanged(object sender, EventArgs e)
    {
        MaintainScrollPositionOnPostBack = true;
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from sorder where so_no='" + ddlorderno.SelectedItem.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "sale");
        if (ds.Tables["sale"].Rows.Count > 0)
        {
            ddlorderno.SelectedItem.Text = Convert.ToString(ds.Tables["sale"].Rows[0].ItemArray[0]);
            txtorderdate.Text = Convert.ToString(ds.Tables["sale"].Rows[0].ItemArray[1]);
            txtcustid.Text = Convert.ToString(ds.Tables["sale"].Rows[0].ItemArray[2]);
            //txtsid.Text = Convert.ToString(ds.Tables["sale"].Rows[0].ItemArray[2]);
        }
        c.cmd.CommandText = "select item_id from sodetails where so_no='" + ddlorderno.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "sale");
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
       
    }
    protected void txttotal_TextChanged(object sender, EventArgs e)
    {
        
    }
    //protected void txtqa_TextChanged(object sender, EventArgs e)
    //{
    //    p = Convert.ToDouble(txtprice.Text);
    //    q = Convert.ToInt16(txtqa.Text);
    //    tp = Convert.ToDouble(p * q);
    //    txttotal.Text = Convert.ToString(tp);
    //    c = new connect();
    //    c.cmd.CommandText = "select * from purbill where bill_no='" + txtbillno.Text + "'";
    //    adp.SelectCommand = c.cmd;
    //    adp.Fill(ds, "bill");
    //    if (ds.Tables["bill"].Rows.Count > 0)
    //    {
    //        grand = Convert.ToDouble(ds.Tables["bill"].Rows[0].ItemArray[4]);
    //    }

    //    gt = grand + (Convert.ToDouble(txttotal.Text));
    //    txtgtotal.Text = (Convert.ToString(gt));
    //}
    //protected void btnreject_Click(object sender, EventArgs e)
    //{
    //    //Response.Redirect("~/preturn.aspx");
    //    Panel6.Visible = true;
    //    DateTime dt = System.DateTime.Now;
    //    txtdate.Text = Convert.ToString(dt.Date.ToShortDateString());
    //    txtbill.Text = txtbillno.Text;
    //    txtr.Text = txtqr.Text;
    //    txtq.Text = txtqty.Text;
    //    c = new connect();
    //    if (IsPostBack)
    //    {
    //        c.cmd.CommandText = "select count(*) from preturn";
    //        int i = Convert.ToInt16(c.cmd.ExecuteScalar());
    //        i++;
    //        txtret.Text = billno + i.ToString();
    //    }

    //}
    //protected void txtrej_TextChanged(object sender, EventArgs e)
    //{
    //    p = Convert.ToDouble(txtqty.Text);
    //    q = Convert.ToInt16(txtqa.Text);
    //    tp = Convert.ToDouble(p - q);
    //    txtrej.Text = Convert.ToString(tp);
    //}
    //protected void btnret_Click(object sender, EventArgs e)
    //{
    //    c = new connect();
    //    ds = new DataSet();
    //    //int retno = 0;
    //    //int no = retno + 1;

    //    //int qty;
    //    //qty = (Convert.ToInt16(txtqr.Text)) - (Convert.ToInt16(txtqa.Text));
    //    //txtrej.Text = Convert.ToString(qty);
    //    c.cmd.CommandText = "insert into preturn values(@preturnno,@bill_no,@date,@tot_no_of_pc)";
    //    c.cmd.Parameters.Add("@preturnno", SqlDbType.NVarChar).Value = txtret.Text;
    //    c.cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar).Value = txtbill.Text;
    //    c.cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = txtdate.Text;
    //    c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = txtr.Text;
    //    c.cmd.ExecuteNonQuery();
    //    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Returned')</script>");
    //}
    protected void txtqty_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void txtdiscount_TextChanged(object sender, EventArgs e)
    {
        p = Convert.ToDouble(txtqty.Text);
        q = Convert.ToInt16(txtprice.Text);
        r = Convert.ToInt16(txtdiscount.Text);
        tp = Convert.ToDouble(p * q);
        txttotal.Text = Convert.ToString(tp);
        c = new connect();
        c.cmd.CommandText = "select * from salesbill where sbill_no='" + txtbillno.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "bill");
        if (ds.Tables["bill"].Rows.Count > 0)
        {
            grand = Convert.ToDouble(ds.Tables["bill"].Rows[0].ItemArray[4]);
        }
        gt = grand + (Convert.ToDouble(txttotal.Text) -(r / 100));
        txtgtotal.Text = (Convert.ToString(gt));
    }
    protected void btnnext_Click(object sender, EventArgs e)
    {
        //ddlorderno.Enabled = false;
        try
        {
            if (ddlorderno.SelectedIndex == 0 || ddlproid.SelectedIndex == 0 || ddlpmode.SelectedIndex == 0 || txtdiscount.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('ENTER ALL FIELDS!!!')</script>");
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("sbill_no");
                dt.Columns.Add("item_id");
                dt.Columns.Add("item_name");
                dt.Columns.Add("quantity");
                dt.Columns.Add("amt");
                dt.Columns.Add("price");
                DataRow dr = null;
                if (ViewState["sbill"] != null)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        dt = (DataTable)ViewState["sbill"];
                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.NewRow();
                            dr["sbill_no"] = txtbillno.Text;
                            dr["item_id"] = ddlproid.SelectedItem.Text;
                            dr["item_name"] = txtitname.Text;
                            dr["quantity"] = txtqty.Text;
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
                    dr["sbill_no"] = txtbillno.Text;
                    dr["item_id"] = ddlproid.SelectedItem.Text;
                    dr["item_name"] = txtitname.Text;
                    dr["quantity"] = txtqty.Text;
                    dr["amt"] = txtprice.Text;
                    dr["price"] = txttotal.Text;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }

                ViewState["sbill"] = dt;
                //c.cmd.CommandText = "insert into pbdetails values (@item_id,@bill_id,@no_of_pc,@amt,@price)";
                //c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = ddlproid.SelectedItem.Text;
                //c.cmd.Parameters.Add("@bill_id", SqlDbType.NVarChar).Value = txtbillno.Text;
                //c.cmd.Parameters.Add("@no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(txtqty.Text);
                //c.cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Convert.ToDecimal(txtprice.Text);
                //c.cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txttotal.Text);

                //c.cmd.ExecuteNonQuery();

                //    Session["pono"] = TextBox1.Text;
                //    Session["iid"] = Label2.Text;
                //    Session["qty"] = TextBox4.Text;
                //    Session["HSN"] = Label3.Text;
                // ddlproid.SelectedIndex=0;
                //ddlproid.SelectedItem.Enabled = false;
                //// ddlproid.SelectedValue.Remove(1);
                //txtqty.Text = "";
                //txtprice.Text = "";
                //txttotal.Text = "";
                c = new connect();
                ds = new DataSet();
                int qty1, qty2;
                c.cmd.CommandText = "insert into sbdetails values(@sbill_no,@item_id,@amt,@no_of_pc,@price)";
                c.cmd.Parameters.Clear();
                if (txtprice.Text != "")
                {
                    c.cmd.Parameters.Add("@sbill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
                    c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = ddlproid.Text;
                    c.cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Convert.ToDecimal(txtprice.Text);
                    c.cmd.Parameters.Add("@no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(txtqty.Text);
                    c.cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txttotal.Text);
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "update sorder set status='paid' where so_no='" + ddlorderno.SelectedItem.Text + "'";
                    c.cmd.ExecuteNonQuery();
                    Session["billno"] = txtbillno.Text;
                    c.cmd.CommandText = "select * from salesbill where sbill_no='" + txtbillno.Text + "'";
                    adp.SelectCommand = c.cmd;
                    ds = new DataSet();
                    adp.Fill(ds, "pur");
                    if (ds.Tables["pur"].Rows.Count > 0)
                    {
                        c.cmd.CommandText = "update salesbill set sbill_no='" + txtbillno.Text + "'," + "so_no='" + ddlorderno.SelectedItem.Text + "'," + "s_date='" + txtorderdate.Text + "'," + "p_mode='" + ddlpmode.SelectedItem.Text + "'," + "gtot='" + txtgtotal.Text + "'," + "discount='" + txtdiscount.Text + "'" + " where sbill_no='" + txtbillno.Text + "'";
                        c.cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        c.cmd.CommandText = "insert into salesbill values(@sbill_no,@so_no,@s_date,@p_mode,@gtot,@discount)";
                        c.cmd.Parameters.Clear();
                        c.cmd.Parameters.Add("@sbill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
                        c.cmd.Parameters.Add("@so_no", SqlDbType.NVarChar).Value = ddlorderno.SelectedItem.Text;
                        c.cmd.Parameters.Add("@s_date", SqlDbType.DateTime).Value = txtbilldate.Text;
                        c.cmd.Parameters.Add("@p_mode", SqlDbType.NVarChar).Value = ddlpmode.SelectedItem.Text;
                        c.cmd.Parameters.Add("@gtot", SqlDbType.Decimal).Value = Convert.ToDecimal(txtgtotal.Text);
                        c.cmd.Parameters.Add("@discount", SqlDbType.SmallInt).Value = Convert.ToInt16(txtdiscount.Text);
                        c.cmd.ExecuteNonQuery();
                    }
                    Session["gtotal"] = txtgtotal.Text;
                    c.cmd.CommandText = "select no_of_box from stock where item_id='" + ddlproid.SelectedItem.ToString() + "'";
                    adp.SelectCommand = c.cmd;
                    adp.Fill(ds, "stk");
                    if (ds.Tables["stk"].Rows.Count > 0)
                    {
                        qty1 = Convert.ToInt16(ds.Tables["stk"].Rows[0].ItemArray[0]);
                        qty2 = qty1 - Convert.ToInt16(txtqty.Text);
                        c.cmd.CommandText = "update stock set no_of_box=@no_of_box where item_id='" + ddlproid.SelectedItem.ToString() + "'";
                        c.cmd.Parameters.Add("@no_of_box", SqlDbType.SmallInt).Value = qty2;
                        c.cmd.ExecuteNonQuery();


                    }

                //        c.cmd.CommandText = "select * from salesbill where sbill_no='" + Session["billno"] + "'";
                    //        ds = new DataSet();
                    //        adp.Fill(ds, "sales");
                    //        if (ds.Tables["sales"].Rows.Count > 0)
                    //        {
                    //            GridView1.DataSource = ds.Tables["sales"];
                    //            GridView1.DataBind();
                    //        }
                    //        c.cmd.CommandText = "select * from sbdetails where sbill_no='" + Session["billno"] + "'";
                    //        ds = new DataSet();
                    //        adp.Fill(ds, "sales");
                    //        if (ds.Tables["sales"].Rows.Count > 0)
                    //        {
                    //            GridView2.DataSource = ds.Tables["sales"];
                    //            GridView2.DataBind();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("no records found ");
                    //    }
                    //}
                    else
                    {
                        MessageBox.Show("must enter price");
                    }

                }

                ddlproid.SelectedItem.Enabled = false;
                txtqty.Text = "";
                txtprice.Text = "";
                txttotal.Text = "";
                ddlpmode.SelectedIndex = 0;
                txtdiscount.Text = "";
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
    protected void txtbillno_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtcustid_TextChanged(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from customer where cust_id='" + txtcustid .Text  + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "c");
        if (ds.Tables["c"].Rows.Count > 0)
        {
            txtcustname.Text = Convert.ToString(ds.Tables["c"].Rows[0].ItemArray[1]);

        }
        
    }
}

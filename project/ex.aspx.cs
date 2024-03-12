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
public partial class ex : System.Web.UI.Page
{
    connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        MaintainScrollPositionOnPostBack = true;
        c = new connect();
        ds = new DataSet();
       // GridView1.Visible = false;
        if (!IsPostBack)
        {
            try
            {
                int count;
                txt3.Text = DateTime.Now.ToShortDateString();
                c.cmd.CommandText = "select count(*) from purbill";
                count = Convert.ToInt16(c.cmd.ExecuteScalar()) + 1;
                txt1.Text = "B100" + count.ToString();
                if (ddl1.Items.Count == 0)
                {
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
    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
            //        c = new connect();
            //        ds = new DataSet();
            //        GridView1.Visible = true;
            //        c.cmd.CommandText = "select podetails.item_id,stock.it_name,stock.pc_per_box,stock.no_of_box,podetails.tot_no_of_pc,stock.price from podetails,stock where podetails.item_id=stock.item_id and po_no='" + ddl1.SelectedItem.Text + "'";
            //        adp.SelectCommand = c.cmd;
            //        adp.Fill(ds, "d");
            //        if (ds.Tables["d"].Rows.Count > 0)
            //        {
            //            GridView1.DataSource = ds.Tables["d"];
            //            GridView1.DataBind();
            //            // Label1.Visible = false;
            //        }
            //        else
            //        {
            //            MessageBox.Show("no records");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //    finally
            //    {
            //        c.cnn.Close();
            //    }
            //}

         try
        {
            c = new connect();
            ds = new DataSet();

                c.cmd.CommandText = "select * from podetails where po_no='" + ddl1.SelectedItem.Text + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "po");
                if (ds.Tables["po"].Rows.Count > 0)
                {
                    ddl2.Items.Add("select");
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

    
    protected void ddl2_SelectedIndexChanged(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        ds1 = new DataSet();
        try
        {
            c.cmd.CommandText = "select * from podetails where po_no='" + ddl1.SelectedItem.Text + "' and item_id='" + ddl2.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "po");
            if (ds.Tables["po"].Rows.Count > 0)
            {
                c.cmd.CommandText = "select * from stock where item_id='" + ddl2.SelectedItem.Text + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds1, "it");
                if (ds1.Tables["it"].Rows.Count > 0)
                {

                    txt6.Text = Convert.ToString(ds.Tables["po"].Rows[0].ItemArray[2]);
                    txt5.Text = Convert.ToString(ds1.Tables["it"].Rows[0].ItemArray[3]);
                    txt8.Text = Convert.ToString(ds1.Tables["it"].Rows[0].ItemArray[4]);
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
     
           
        
       
        c.cmd.CommandText = "select * from podetails where item_id='" + ddl2.SelectedItem.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "po");
        if (ds.Tables["po"].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables["po"].Rows.Count; i++)
            {
               // ddl2.Items.Add(Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[1]));
                txt6.Text  = Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[2]);
            }

        }
        else
        {
            MessageBox.Show("no records found ");
        }
    

   
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from stock where item_id='" + ddl2.SelectedItem.Text + "'";
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "it");
        //if (DropDownList3 .Items .Count ==0)
        //{
        if (ds.Tables["it"].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables["it"].Rows.Count; i++)
            {
               txt5.Text  = Convert.ToString(ds.Tables["it"].Rows[i].ItemArray[3]);
               // Label2.Text = Convert.ToString(ds.Tables["it"].Rows[i].ItemArray[1]);

            }
            //}
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
    protected void txt7_TextChanged(object sender, EventArgs e)
    {
       
        
    }
    protected void btnnext_Click(object sender, EventArgs e)
    {
        try
        {
        
            DataTable dt = new DataTable();
            dt.Columns.Add("item_id");
            dt.Columns.Add("item_name");
            dt.Columns.Add("tot_no_of_pc");
            dt.Columns.Add("price");
            dt.Columns.Add("amt");
            DataRow dr = null;
            if (ViewState["pbill"] != null)
            {
                for (int i = 0; i < 1; i++)
                {
                    dt = (DataTable)ViewState["pbill"];
                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.NewRow();
                        dr["item_id"] = ddl2.SelectedItem.Text;
                        dr["item_name"] = txt5.Text;
                        dr["tot_no_of_pc"] = txt6.Text;
                        dr["price"] = txt8.Text;
                        dr["amt"] = txt11.Text;
                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }

            else
            {
                dr = dt.NewRow();
                dr["item_id"] = ddl2.SelectedItem.Text;
                dr["item_name"] = txt5.Text;
                dr["tot_no_of_pc"] = txt6.Text;
                dr["price"] = txt8.Text;
                dr["amt"] = txt11.Text;
                dt.Rows.Add(dr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            ViewState["pbill"] = dt;
                c.cmd.CommandText = "insert into pbdetails values (@bill_no,@item_id,@amt,@no_of_pc,@price)";
                c.cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar).Value = txt1.Text;
                c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = ddl2.SelectedItem.Text;
                c.cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Convert.ToDouble(txt9.Text);
                c.cmd.Parameters.Add("@no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16(txt11.Text);
                c.cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDouble(txt8.Text);
                c.cmd.ExecuteNonQuery();

                ddl2.SelectedIndex = 0;
                txt5.Text = "";
                txt6.Text = "";
                txt7.Text = "";
                txt8.Text = "";
                txt9.Text = "";
                txt10.Text = "";
                txt11.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                c.cnn.Close();
            }
            

            //Session["pono"] = TextBox1.Text;
            //Session["iid"] = Label2.Text;
            //Session["qty"] = TextBox4.Text;

            //Session["odate"] = TextBox2.Text;
            //Session["ddate"] = TextBox3.Text;
            //ddl2.SelectedIndex = 0; 
            //txt5.Text = "";
            //txt6.Text = "";
            //txt7.Text = "";
            //txt8.Text = "";
            //txt9.Text = "";
            //txt10.Text = "";


            //dr["item_id"] = ddl2.SelectedItem.Text;
            //dr["item_name"] = txt5.Text;
            //dr["tot_no_of_pc"] = txt7.Text;
            //dr["amt"] = txt9.Text;
            //Session["item_id"] = ddl2.SelectedItem.Text;
            //Session["item_name"] = txt5.Text;
            //Session["tot_no_of_pc"] = txt7.Text;
            //Session ["amt"] = txt9.Text;

        //}
        //catch (Exception)
        //{
        //     throw;
        //}
        //finally
        //{
        //    c.cnn.Close();
        //}
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        try
        {
            c=new connect();
            ds=new DataSet ();
            c.cmd.CommandText ="insert into purbill values(@bill_no,@po_no,@p_date,@s_billno,@gtot)";
            c.cmd.Parameters .Clear ();
            c.cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar).Value =txt1.Text;
            c.cmd .Parameters .Add ("@po_no",SqlDbType .NVarChar ).Value =ddl1.SelectedItem.ToString () ;
            c.cmd .Parameters .Add ("@p_date",SqlDbType .DateTime ).Value=Convert.ToDateTime (txt3.Text );
            c.cmd .Parameters .Add ("@s_billno",SqlDbType .SmallInt ).Value =Convert .ToInt16 (txt2.Text );
            c.cmd.Parameters.Add("@gtot", SqlDbType.Decimal).Value = "0";
                //Convert .ToDecimal (txt10 .Text );
            c.cmd .ExecuteNonQuery ();
        }
        catch (Exception )
        {
            throw ;
        }
        finally 
        {
            c.cnn .Close ();
        }
    }
    protected void btnaccept_Click(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        try
        {
          
           
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
    protected void txt11_TextChanged(object sender, EventArgs e)
    {
        txt9.Text = Convert.ToString((Convert.ToInt32(txt11.Text)) * (Convert.ToInt32(txt8.Text)));
    }
    protected void txt9_TextChanged(object sender, EventArgs e)
    {

    }
}
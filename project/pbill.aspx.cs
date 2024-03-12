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

public partial class pbill : System.Web.UI.Page
{
    connect c;
    DataSet ds, ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        GridView1.Visible = false;
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
        try
        {
            c = new connect();
            ds = new DataSet();
            GridView1.Visible = true;
            c.cmd.CommandText = "select podetails.item_id,stock.it_name,stock.pc_per_box,stock.no_of_box,podetails.tot_no_of_pc,stock.price from podetails,stock where podetails.item_id=stock.item_id and po_no='" + ddl1.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "d");
            if (ds.Tables["d"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["d"];
                GridView1.DataBind();
                // Label1.Visible = false;
            }
            else
            {
                MessageBox.Show("no records");
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
    protected void btnadd_Click(object sender, EventArgs e)
    {
        try
        {
            c=new connect();
            ds=new DataSet ();
            c.cmd.CommandText ="insert into purbill values(@bill_no,@po_no,@p_date,@s_billno,@gtot)";
            c.cmd.Parameters .Clear ();
            c.cmd .Parameters .Add ("@bill_no",SqlDbType .SmallInt ).Value =Convert .ToInt16 (txt1.Text );
            c.cmd .Parameters .Add ("@po_no",SqlDbType .NVarChar ).Value =ddl1.SelectedItem .Text ;
            c.cmd .Parameters .Add ("@p_date",SqlDbType .DateTime ).Value=Convert .ToDateTime (txt3.Text );
            c.cmd .Parameters .Add ("@s_billno",SqlDbType .SmallInt ).Value =Convert .ToInt16 (txt2.Text );
            c.cmd .Parameters .Add ("@gtot",SqlDbType .Decimal ).Value =Convert .ToDecimal (txt10 .Text );
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
    }



    //    c = new connect();
    //    ds = new DataSet();

    //    try
    //    {
    //        c.cmd.CommandText = "select * from podetails where po_no='" + ddl1.SelectedItem.Text + "'";
    //        adp.SelectCommand = c.cmd;
    //        adp.Fill(ds, "po");
    //        if (ds.Tables["po"].Rows.Count > 0)
    //        {
    //            for (int i = 0; i < ds.Tables["po"].Rows.Count; i++)
    //            {
    //                ddl2.Items .Add ( Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[1]));
    //                //txt6.Text  = Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[2]);
    //            }

    //        }
    //        else
    //        {
    //            MessageBox.Show("no records found ");
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
    //protected void ddl2_SelectedIndexChanged(object sender, EventArgs e)
    //{
        //c = new connect();
        //ds = new DataSet();
        //ds1 = new DataSet();
        //try
        //{
//            c.cmd.CommandText = "select * from podetails where item_id='" + ddl2.SelectedItem.Text + "'and po_no='" + ddl1.SelectedItem.Text + "'";
//            adp.SelectCommand = c.cmd;
//            adp.Fill(ds, "po");
//            if (ds.Tables["po"].Rows.Count > 0)
//            {
//                c.cmd.CommandText = "select * from stock where item_id='" + ddl2.SelectedItem.Text + "'";
//                adp.SelectCommand = c.cmd;
//                adp.Fill(ds1, "it");
//                if (ds1.Tables["it"].Rows.Count > 0)
//                {

//                    txt6.Text = Convert.ToString(ds.Tables["po"].Rows[0].ItemArray[2]);
//                    txt5.Text = Convert.ToString(ds1.Tables["it"].Rows[0].ItemArray[3]);
//                }
//                else
//                {
//                    MessageBox.Show("no records found ");
//                }
//            }
//            else
//            {
//                MessageBox.Show("no records found ");
//            }
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            c.cnn.Close();
//        }
//    }
//}


        //c = new connect();
        //ds = new DataSet();
        //try
        //{
        //    c.cmd.CommandText = "select * from podetails where item_id='" + ddl2.SelectedItem.Text + "'";
        //    adp.SelectCommand = c.cmd;
        //    adp.Fill(ds, "po");
        //    if (ds.Tables["po"].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < ds.Tables["po"].Rows.Count; i++)
        //        {
        //           // ddl2.Items.Add(Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[1]));
        //            txt6.Text  = Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[2]);
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("no records found ");
        //    }
        //}
        //catch (Exception)
        //{
        //    throw;
        //}
        //finally
        //{
        //    c.cnn.Close();
        //}
    //    }
    //}
        //try
        //{

        //    c = new connect();
        //    ds = new DataSet();
        //    c.cmd.CommandText = "select * from stock where item_id='" + ddl2.SelectedItem.Text + "'";
        //    adp.SelectCommand = c.cmd;
        //    adp.Fill(ds, "it");
        //    //if (DropDownList3 .Items .Count ==0)
        //    //{
        //    if (ds.Tables["it"].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < ds.Tables["it"].Rows.Count; i++)
        //        {
        //           txt5.Text  = Convert.ToString(ds.Tables["it"].Rows[i].ItemArray[3]);
        //           // Label2.Text = Convert.ToString(ds.Tables["it"].Rows[i].ItemArray[1]);

        //        }
                //}
        //    }
        //}
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    finally
    //    {
    //        c.cnn.Close();
    //    }
    //}
    


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

public partial class purbill : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        if (!IsPostBack)
        {
            try
            {           
                int count;
                TextBox2.Text = DateTime.Now.ToShortDateString();
                c.cmd.CommandText = "select count(*) from purbill";
                count = Convert.ToInt16(c.cmd.ExecuteScalar()) + 1;
                TextBox1.Text = "B100" + count.ToString();

                    //TextBox9.Text = (string)Session["pono"];
                   // TextBox5.Text = (string)Session["odate"];
                if (DropDownList1.Items.Count == 0)
                    {
                        c.cmd.CommandText = "select distinct(po_no) from porder";
                        adp.SelectCommand = c.cmd;
                        adp.Fill(ds, "o");
                        if (ds.Tables["o"].Rows.Count > 0)
                        {
                            DropDownList1.Items.Add("select");
                            int i;
                            for (i = 0; i < ds.Tables["o"].Rows.Count; i++)
                            {
                               DropDownList1 .Items.Add(ds.Tables["o"].Rows[i].ItemArray[0].ToString());
                               //TextBox5.Text = Convert.ToString(ds.Tables["o"].Rows[i].ItemArray[1]);
                               //TextBox3.Text = Convert.ToString(ds.Tables["o"].Rows[i].ItemArray[2]);
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from porder where po_no='" + DropDownList1.SelectedItem.Text + "'";
           // c.cmd.CommandText = "select * from porder,podetails where po_no.porder,po_no.podetails='" + DropDownList1.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "p");       
                if (ds.Tables["p"].Rows.Count > 0)
                {
                   DropDownList2.Items.Add("select");
                    for (int i = 0; i < ds.Tables["p"].Rows.Count; i++)
                    {
                        //DropDownList2.Items.Add("select");
                        TextBox5.Text = Convert.ToString(ds.Tables["p"].Rows[i].ItemArray[1]);
                        //TextBox9.Text = Convert.ToString(ds.Tables["p"].Rows[i].ItemArray[1]);

                        //  TextBox3.Text = Convert.ToString(ds.Tables["p"].Rows[i].ItemArray[2]);
                        DropDownList2.Items.Add(Convert.ToString(ds.Tables["p"].Rows[i].ItemArray[2]));
                    }
            }
            //c.cmd.CommandText = "select * from podetails where po_no='" + DropDownList1.SelectedItem.Text + "'";
            //adp.SelectCommand = c.cmd;
            //adp.Fill(ds, "c");

            //if (ds.Tables["c"].Rows.Count > 0)
            //{
               
            //    for (int i = 0; i < ds.Tables["c"].Rows.Count; i++)
            //    {
                    
            //        TextBox9.Text = Convert.ToString(ds.Tables["c"].Rows[i].ItemArray[1]);
            //        TextBox8.Text = Convert.ToString(ds.Tables["p"].Rows[i].ItemArray[2]);

                  
            //    }
            //}
            
            try
            {
                GridView1.Visible = false;
                c = new connect();
                ds = new DataSet();
                c.cmd.CommandText = "select * from podetails where  po_no='" + DropDownList1.SelectedItem.Text + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "aa");
                if (ds.Tables["aa"].Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < ds.Tables["aa"].Rows.Count; i++)
                    {
                       Label1 .Text =Convert .ToString  (ds.Tables["aa"].Rows[i].ItemArray[1].ToString());
                       Label2.Text = Convert.ToString(ds.Tables["aa"].Rows[i].ItemArray[2].ToString());
                    }
                }
                c.cmd.CommandText = "select * from stock where  item_id='" + Label1.Text + "'";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "bb");
                if (ds.Tables["bb"].Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < ds.Tables["bb"].Rows.Count; i++)
                    {
                        Label3.Text = Convert.ToString(ds.Tables["bb"].Rows[i].ItemArray[2].ToString());
                        Label4.Text = Convert.ToString(ds.Tables["bb"].Rows[i].ItemArray[3].ToString());

                    }
                }
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
                            dr["item_id"] = Label1.Text;
                            dr["HSN"] = Label3.Text;
                            dr["i_name"] = Label4.Text;
                            dr["tot_no_of_pc"] = Label2.Text;
                            dt.Rows.Add(dr);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
                else
                {
                    dr = dt.NewRow();
                    dr["item_id"] = Label1.Text;
                    dr["HSN"] = Label3.Text;
                    dr["i_name"] = Label4.Text;
                    dr["tot_no_of_pc"] = Label2.Text;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                ViewState["porder"] = dt;
                //c.cmd.CommandText = "insert into podetails values (@po_no,@item_id,@tot_no_of_pc)";
                //c.cmd.Parameters.Add("@po_no", SqlDbType.NVarChar).Value = TextBox1.Text;
                //c.cmd.Parameters.Add("@item_id", SqlDbType.NVarChar).Value = (string)Session["item_id"];
                //c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = Convert.ToInt16((string)Session["tot_no_of_pc"]);
                //c.cmd.ExecuteNonQuery();
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
        catch (Exception)
        {
            throw;
        }
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    c = new connect();
        //    ds = new DataSet();
        //    c.cmd.CommandText = "select * from supplier where sup_id='" + TextBox3 .Text + "'";
        //    adp.SelectCommand = c.cmd;
        //    adp.Fill(ds, "z");
        //  // if(ddl1 .SelectedIndex ==0)
            
        //    if (ds.Tables["z"].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < ds.Tables["z"].Rows.Count; i++)
        //        {
        //            Label1.Text = Convert.ToString(ds.Tables["z"].Rows[i].ItemArray[1]);
        //            //TextBox4.Text = Convert.ToString(ds.Tables["z"].Rows[i].ItemArray[1]);
        //            //TextBox3.Text = Convert.ToString(ds.Tables["p"].Rows[i].ItemArray[2]);
        //        }
        //    }

        //}
        //catch (Exception)
        //{
        //    throw;
        //}
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from supplier where sup_id='" + DropDownList2.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "y");
            
                if (ds.Tables["y"].Rows.Count > 0)
                {
                    
                    for (int i = 0; i < ds.Tables["y"].Rows.Count; i++)
                    {
                        
                      TextBox3.Text = Convert.ToString(ds.Tables["y"].Rows[i].ItemArray[1]);
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
        //DropDownList1.Enabled = false;
        //DropDownList2.Enabled = false;
        //GridView1.Visible = true; 
        c = new connect();
        ds = new DataSet();
        try 
        {
            c.cmd.CommandText = "select item_id,tot_no_of_pc from podetails where po_no='"+DropDownList1.SelectedItem .Text+"'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "po");
            if (ds.Tables["po"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["po"].Rows.Count; i++) 
                {
                    TextBox9 .Text  = Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[1]);
                    TextBox8 .Text = Convert.ToString(ds.Tables["po"].Rows[i].ItemArray[2]);
                }
               
            }
            else
            {
                //Label1.Visible = true;
                Label1.Text = "no records found ";
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
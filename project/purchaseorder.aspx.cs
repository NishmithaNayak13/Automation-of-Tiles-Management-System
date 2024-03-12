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
public partial class purchaseorder : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp=new SqlDataAdapter() ;
    protected void Page_Load(object sender, EventArgs e)
    {
        c=new connect() ;
        ds = new DataSet();
        txttnop .Focus ();                                       
        try 
        {
            if (ddlname .Items .Count ==0)
            {
                c.cmd .CommandText ="select (name) from supplier where status='active'";
                adp.SelectCommand =c.cmd ;
                adp .Fill (ds,"sup");
                if (ds.Tables ["sup"].Rows .Count >0)
                {
                    ddlname .Items .Add ("Select");
                    for (int i = 0; i < ds.Tables["sup"].Rows.Count;i++ )
                    {
                        ddlname.Items.Add(ds.Tables["sup"].Rows[i].ItemArray[1].ToString());
                    }
                }
            }
            if(!IsPostBack )
            {
                Calendar1 .Visible =false ;
            }
            if((string )Session ["reorder"]=="yes")
            {
                c.cmd .CommandText ="select * from stock where tot_no_of_pc<reorder";
                adp.SelectCommand =c.cmd ;
                adp .Fill(ds,"stk");
                if(ds.Tables ["stk"].Rows .Count >0)
                {
                    GridView1 .DataSource =ds.Tables ["stk"];
                    GridView1 .DataBind ();
                }
            }
            Label1 .Text =DateTime .Now .ToShortDateString ();
            if((string )Session ["nextpur"]=="yes")
            {
                Button4 .Visible =false ;
                btnorder .Visible =true ;
                txtorder .Text =(string )Session ["purno"];
            }
            int count1;
            c.cmd .CommandText ="select count(*)from purchase_order";
            count1=Convert .ToInt16 (c.cmd.ExecuteScalar ())+1;
            Label2.Text =count1.ToString ();
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




    protected void btnorder_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "insert into purchase_order values of(@p_id,@pror_no,@p_date,@due_date)";
            c.cmd.Parameters.Clear();
            if (txtorder.Text != "" && txtid.Text != "" && txtduedt.Text != "")
            {
                c.cmd.Parameters.Add("@p_id", SqlDbType.NVarChar).Value = Label2.Text;
                c.cmd.Parameters.Add("@pror_no", SqlDbType.NVarChar).Value = txtorder.Text;
                c.cmd.Parameters.Add("@p_date", SqlDbType.DateTime).Value = Label1.Text;
                c.cmd.Parameters.Add("@due_date", SqlDbType.DateTime).Value = txtduedt.Text;
                c.cmd.ExecuteNonQuery();
                Session["purno"] = txtorder.Text;



            }
        }
        catch (Exception)
        {
            throw;
        }
    }

//protected void  btnorder_Click(object sender, EventArgs e)
//{

//}
protected void  GridView1_SelectedIndexChanged(object sender, EventArgs e)
{
}
    protected void btndisplay_Click(object sender, EventArgs e)
    {

    }
}


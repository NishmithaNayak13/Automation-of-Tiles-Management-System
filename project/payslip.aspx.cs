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
public partial class payslip : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        MaintainScrollPositionOnPostBack = true;
        c = new connect();
        ds = new DataSet();
        DateTime dt = DateTime.Now;
       // Panel2 .Visible =false ;
       Label1 .Visible =false ;
        Label2 .Visible =false ;

        if (ddl1.Items.Count == 0)
        {
           // c.cmd.CommandText = "select empno,empname,address,phno,designation,email,DOB,,DOJ,gender,status,salary where status='active'";
            c.cmd.CommandText = "select distinct(empname) from employeedetails where status='active'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "att");
            if (ds.Tables["att"].Rows.Count > 0)
            {
                ddl1.Items.Add("select");
                int i;
                for (i = 0; i < ds.Tables["att"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["att"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }
    protected void  btndisplay_Click(object sender, EventArgs e)
{
        Response .Redirect ("~/payslipdisplay.aspx");
    }

                    
//protected void  btnclear_Click(object sender, EventArgs e)
//{
//    txtbasic.Text = "";
//    txtwork.Text = "";
//    txtleave.Text = "";
//    txtpf.Text = "";
//    txtel.Text = "";
//    txtgross.Text = "";
//    Label1.Text = "";
//    ddl1.SelectedIndex = 0;
//}
//    protected void btnsave_Click(object sender, EventArgs e)
//    {
//        try
//        {
//            c = new connect();
//            ds = new DataSet();
//            c.cmd.CommandText = "select * from salary where empname='" + ddl2.SelectedItem.Text + "' and month='" + ddl1.SelectedItem.Text + "'and year='" + txtwork.Text + "'and b_salary='" + txtleave.Text + "'";
//            adp.SelectCommand = c.cmd;
//            c.cmd.ExecuteNonQuery();
//            adp.Fill(ds, "sal");
//            if (ds.Tables["sal"].Rows.Count > 0)
//            {
//                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('salary details already exist')</script>");
//            }
//            else
//            {
//                if (txtwork.Text != "" && txtpf.Text != "" && txtel.Text != "" && txtdeduct.Text != "" && txtleave.Text != "" && ddl2.SelectedItem.Text != "")
//                {
//                    c.cmd.CommandText = "insert into salary values(@empno,@name,@month,@year,@b_salary,@pf,@e_leave,@sal_deduct,@netpay)";
//                    c.cmd.Parameters.Clear();
//                    c.cmd.Parameters.Add("@empno", SqlDbType.NVarChar).Value = txtbasic.Text;
//                    c.cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = ddl2.SelectedItem.ToString();
//                    c.cmd.Parameters.Add("@month", SqlDbType.NVarChar).Value = ddl1.SelectedItem.ToString();
//                    c.cmd.Parameters.Add("@year", SqlDbType.NVarChar).Value = txtwork.Text;
//                    c.cmd.Parameters.Add("@b_salary", SqlDbType.BigInt).Value = Convert.ToInt32(txtleave.Text);
//                    c.cmd.Parameters.Add("@pf", SqlDbType.SmallInt).Value = Convert.ToInt16(txtpf.Text);
//                    c.cmd.Parameters.Add("@e_leave", SqlDbType.SmallInt).Value = Convert.ToInt16(txtel.Text);
//                    c.cmd.Parameters.Add("@sal_deduct", SqlDbType.SmallInt).Value = Convert.ToInt16(txtdeduct.Text);
//                    c.cmd.Parameters.Add("@netpay", SqlDbType.Decimal).Value = Convert.ToDecimal(Label1.Text);
//                    c.cmd.ExecuteNonQuery();
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('record saved')</script>");
//                }
//                else
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('enter all the fields')</script>");
//                }
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
//    protected void ddl2_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        double pf, basic, deduct, d = 0;
//        int r;
//        try 
//        {
//            c=new connect ();
//            ds1=new DataSet ();
//            ds2=new DataSet ();
//            c.cmd .CommandText ="select * from employeedetails where empname='"+ddl2 .SelectedItem .Text +"'";
//            adp.SelectCommand =c.cmd ;
//            adp.Fill(ds1,"emp");
//            if(ds1.Tables ["emp"].Rows .Count >0)
//            {
//                if(Convert .ToString (ds1.Tables ["emp"].Rows [0].ItemArray [10])=="inactive")
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('employee is inactive')</script>");
//                }
//                else 
//                {
//                    txtleave .Text =Convert .ToString (ds1.Tables["emp"].Rows [0].ItemArray [11]);
//                    txtbasic .Text  =Convert .ToString (ds.Tables ["emp"].Rows[0].ItemArray [0]);
//                }
//            }
//            else 
//            {
//                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('empid does not exist')</script>");
//            }
        
//        c.cmd.CommandText ="select * from attendance where empname='"+ddl2.SelectedItem .Text +"'and month='"+ddl1.SelectedItem .Text +"'";
//        adp.SelectCommand =c.cmd ;
//        adp .Fill (ds2,"att");
//        if(ds2.Tables ["att"].Rows.Count >0)
//        {
//            txtel .Text =Convert .ToString (ds2.Tables["att"].Rows[0].ItemArray [7]);
//            txtwork .Text =Convert .ToString (ds2.Tables ["att"].Rows [0].ItemArray [3]);
//            r=Convert .ToInt32 (ds2.Tables ["att"].Rows [0].ItemArray [7]);
//            pf =Convert .ToDouble (txtel .Text )*4.0/100;
//            txtdeduct .Text =Convert .ToString (pf);
//            if (r>0)
//            {
//                deduct=Convert .ToDouble (txtel .Text )*1.0/100;
//                d=Convert .ToDouble (txtel .Text )*deduct ;
//                txtdeduct .Text =Convert.ToString (d);
//            }
//            else
//            {
//                txtdeduct .Text ="0";
//            }
//            basic=Convert .ToDouble (txtleave .Text )-pf-d;
//            Label1 .Text =Convert .ToString (basic);
//        }
//        else
//        {
//            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('attendance is not calculated')</script>");
//        }
//    }
//        catch (Exception )
//        {
//            throw ;
//        }
//        finally 
//        {
//            c.cnn .Close ();
//        }
//    }
//}

protected void  btnnew_Click(object sender, EventArgs e)
{
    Panel2 .Visible =true ;

}
protected void  btnsubmit_Click(object sender, EventArgs e)
{
    btnsave.Enabled = true;
     c=new connect ();
    DataSet  ds=new DataSet ();
    DataSet ds1=new DataSet ();
    try 
    {
        Panel2.Visible =false ;
        c.cmd.CommandText ="select * from salary where name='"+ddl1.SelectedItem .Text +"'";
        adp.SelectCommand =c.cmd ;
        adp.Fill (ds1,"sal");
        if (ds1.Tables ["sal"].Rows.Count >0)
        {
            txtid .ReadOnly =true ;
            txtname.ReadOnly =true ;
             txtdesig.ReadOnly =true ;
             txtbasic.ReadOnly =true ;
            
             txtgross.ReadOnly =true ;
             txtleave.ReadOnly =true ;
             txtnet.ReadOnly =true ;
             txtpf.ReadOnly =true ;
             txtwork.ReadOnly =true ;
            txtid.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [0]);
             txtname.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [1]);
             txtdesig.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [2]);
             txtbasic.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [3]);
             txtwork.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [4]);
             txtleave.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [5]);
             txtbonus.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [6]);
             txtpf.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [7]);
             txtgross.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [8]);
             txtnet.Text =Convert .ToString (ds1.Tables ["sal"].Rows[0].ItemArray [9]);
           // btnsave .Enabled =false ;
            btncompute .Enabled =true  ;
            return ;
        }
        c.cmd .CommandText ="select empno,empname,designation,salary from employeedetails where status='active' and empname="+ddl1.SelectedItem .Text ;
        adp.SelectCommand =c.cmd ;
        adp.Fill(ds,"pay");
        if(ds.Tables ["pay"].Rows .Count >0)
        {
            c.cmd .CommandText ="select w_day,l_taken from attendance where name="+ddl1.SelectedItem.Text ;
            adp.SelectCommand =c.cmd ;
        adp.Fill(ds1,"basic");
        if(ds1.Tables ["basic"].Rows .Count >0)
        {          
            txtid .Text =Convert .ToString (ds.Tables ["pay"].Rows[0].ItemArray[0]);
            txtname.Text =Convert .ToString (ds.Tables ["pay"].Rows[0].ItemArray [1]);
             txtdesig.Text =Convert .ToString (ds.Tables ["pay"].Rows[0].ItemArray [4]);
             txtbasic.Text =Convert .ToString (ds.Tables ["pay"].Rows[0].ItemArray [11]);
             txtwork.Text =Convert .ToString (ds1.Tables ["basic"].Rows[0].ItemArray [8]);
             txtleave.Text =Convert .ToString (ds1.Tables ["basic"].Rows[0].ItemArray [6]);
        }
        else 
        {
            Label1.Visible =true ;
            Label1.Text ="no records found ";
        }
    }
    else 
    {
        Label1.Visible =true ;
        Label1.Text ="no records found ";
    }
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




    protected void btncompute_Click(object sender, EventArgs e)
    {
        c=new connect ();
        c.cmd.CommandText = "select count(*) from attendance where empno='" + ddl1.SelectedItem.Text + "'and year='" + "'";
        DataSet ds=new DataSet ();
        double net=0;
        try 
        {
            if((txtbonus .Text =="")||(txtid .Text =="")||(txtname .Text =="")||(txtdesig .Text =="")||(txtbasic .Text =="")||(txtwork .Text =="")||(txtleave.Text ==""))
            {
                Label2.Visible =true ;
            return ;
            }
            txtgross .Text =Convert .ToString ((Convert .ToDouble (txtbasic .Text ))+(Convert .ToDouble (txtbonus .Text )));
            txtpf .Text =Convert .ToString ((Convert .ToDouble (txtgross.Text ))*0.12);
            if(Convert .ToInt16(txtpf .Text )>1200)
            {
                txtpf .Text ="1200";
            }
            if(Convert .ToInt16 (txtleave .Text )>4)
            {
                int i=Convert .ToInt16 (txtleave .Text );
                int n=i-4;
                net =(n*0.01)*(Convert .ToDouble (txtgross .Text ));
            }
            txtnet .Text =Convert .ToString ((Convert .ToDouble (txtgross .Text ))-net-(Convert .ToDouble (txtpf.Text )));
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
    protected void btnsave_Click(object sender, EventArgs e)
    {
        c = new connect();
        try
        {
            if (txtbonus.Text == "")
            {
                MessageBox.Show("please enter bonus and compute first ");
                return;
            }
            c.cmd.CommandText = "insert into salary values(@empno,@name,@edesig,@basic,@presentdays,@absentdays,@bonus,@pf,@gross,@net)";
            c.cmd.Parameters.Add("@empno", SqlDbType.NVarChar ).Value =txtid.Text;
            c.cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtname.Text;
            c.cmd.Parameters.Add("@edesig", SqlDbType.NVarChar).Value = txtdesig.Text;
            c.cmd.Parameters.Add("@basic", SqlDbType.Decimal).Value = Convert.ToDouble(txtwork.Text);
            c.cmd.Parameters.Add("@presentdays", SqlDbType.SmallInt).Value = Convert.ToInt16(txtleave.Text);
            c.cmd.Parameters.Add("@absentdays", SqlDbType.SmallInt).Value = Convert.ToInt16(txtleave.Text);
            c.cmd.Parameters.Add("@bonus", SqlDbType.Decimal).Value = Convert.ToDouble(txtbonus.Text);
            c.cmd.Parameters.Add("@pf", SqlDbType.SmallInt).Value = Convert.ToInt16(txtpf.Text);
            c.cmd.Parameters.Add("@gross", SqlDbType.Decimal).Value = Convert.ToDouble(txtgross.Text);
            c.cmd.Parameters.Add("@net", SqlDbType.Decimal).Value = Convert.ToDouble(txtnet.Text);
            c.cmd.ExecuteNonQuery();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('records saved successfully')</script>");
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
        //c = new connect();
       // c.cmd.CommandText = "select empno,empname,address,phno,designation,email,DOB,,DOJ,gender,status,salary where status='active'";

    }
}

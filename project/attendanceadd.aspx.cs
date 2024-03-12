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

public partial class attendanceadd : System.Web.UI.Page
{
    connect c;
    DataSet ds,ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    int yr;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        yr = DateTime.Now.Year;
        txt4.Text = yr.ToString();
        txtstatus.Text = "active";
        //btnsave.Visible = false;
        long m;
        m = Convert.ToInt32(DateTime.Now.Month);
        switch (m)
        {
            case 1: txt3.Text = "January";
                txt5.Text = "31";
                break;
            case 2: txt3.Text = "February";
                if (yr % 4 == 0)
                {
                    txt5.Text = "29";
                }
                else
                {
                    txt5.Text = "28";
                }
                break;
            case 3: txt3.Text = "March";
                txt5.Text = "31";
                break;
            case 4: txt3.Text = "April";
                txt5.Text = "30";
                break;
            case 5: txt3.Text = "May";
                txt5.Text = "31";
                break;
            case 6: txt3.Text = "June";
                txt5.Text = "30";
                break;
            case 7: txt3.Text = "July";
                txt5.Text = "31";
                break;
            case 8: txt3.Text = "August";
                txt5.Text = "31";
                break;
            case 9: txt3.Text = "September";
                txt5.Text = "30";
                break;
            case 10: txt3.Text = "October";
                txt5.Text = "31";
                break;
            case 11: txt3.Text = "November";
                txt5.Text = "30";
                break;
            case 12: txt3.Text = "December";
                txt5.Text = "31";
                break;
        }
        if (ddl1.Items.Count == 0)
        {
            c.cmd.CommandText = "select distinct(empname) from employeedetails where status='active'";
            //c.cmd.CommandText ="select employeedetails.empname from employeedetails where status='active' and attendance.month='"+txt3 .Text+ "' and year='"+txt4.Text +"'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "ep");
            if (ds.Tables["ep"].Rows.Count > 0)
            {
                ddl1.Items.Add("Select");
                int i;
                for (i = 0; i < ds.Tables["ep"].Rows.Count; i++)
                {
                    ddl1.Items.Add(ds.Tables["ep"].Rows[i].ItemArray[0].ToString());
                }
            }
        }
    }


    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds1 = new DataSet();
            c.cmd.CommandText = "select * from attendance where name='" + ddl1.SelectedItem.Text + "' and month='" + txt3.Text + "' and year='" + txt4.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds1, "att");
            if (ds1.Tables["att"].Rows.Count > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Attendance is already done')</script>");
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                txt6.Text = "";
                txt7.Text = "";
                txt8.Text = "";
                txt9.Text = "";
                ddl1.SelectedIndex = 0;
            }
            else
            {
                if (txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && txt7.Text != "" && txt8.Text != "" && txt9.Text != "")
                {
                    c.cmd.CommandText = "insert into attendance values(@emp_id,@name,@month,@year,@ttldays,@l_given,@l_taken,@e_leave,@w_day,@status)";
                    c.cmd.Parameters.Clear();
                    c.cmd.Parameters.Add("@emp_id", SqlDbType.NVarChar).Value = txt1.Text;
                    c.cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txt2.Text;
                    c.cmd.Parameters.Add("@month", SqlDbType.NVarChar).Value = txt3.Text;
                    c.cmd.Parameters.Add("@year", SqlDbType.BigInt).Value = Convert.ToInt32(txt4.Text);
                    c.cmd.Parameters.Add("@ttldays", SqlDbType.BigInt).Value = Convert.ToInt32(txt5.Text);
                    c.cmd.Parameters.Add("@l_given", SqlDbType.BigInt).Value = Convert.ToInt32(txt6.Text);
                    c.cmd.Parameters.Add("@l_taken", SqlDbType.BigInt).Value = Convert.ToInt32(txt7.Text);
                    c.cmd.Parameters.Add("@e_leave", SqlDbType.BigInt).Value = Convert.ToInt32(txt8.Text);
                    c.cmd.Parameters.Add("@w_day", SqlDbType.BigInt).Value = Convert.ToInt32(txt9.Text);
                    c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = txtstatus.Text;
                    c.cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record saved')</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter all feilds')</script>");
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
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txt1.Text = "";
        txt2.Text = "";
        txt3.Text = "";
        txt4.Text = "";
        txt5.Text = "";
        txt6.Text = "";
        txt7.Text = "";
        txt8.Text = "";
        txt9.Text = "";
        txtstatus.Text = "";
        ddl1.SelectedIndex = 0;
    }
    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            ds = new DataSet();
            c.cmd.CommandText = "select * from employeedetails where empname='" + ddl1.SelectedItem.Text + "'";
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "emp");
            //if(ddl1 .SelectedIndex ==0)
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('valid emp_id')</script>");
            //}
            //else 
            //{
            if (ds.Tables["emp"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
                {
                    txt1.Text = Convert.ToString(ds.Tables["emp"].Rows[i].ItemArray[0]);
                    txt2.Text = Convert.ToString(ds.Tables["emp"].Rows[i].ItemArray[1]);
                }
            }
            //else 
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('emp_id does not exist')</script>");
            //}
            //}
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void txt7_TextChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txt7.Text) > 2)
        {
            txt8.Text = Convert.ToString((Convert.ToInt32(txt7.Text)) - (Convert.ToInt32(txt6.Text)));
        }
        else if (Convert.ToInt32(txt7.Text) <= 2 && (Convert.ToInt32(txt7.Text) >= 0))
        {
            txt8.Text = Convert.ToString("0");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('invalid leave taken')</script>");
        }
        if (Convert.ToInt32(txt7.Text) > Convert.ToInt32(txt5.Text))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('leave taken must be less than total days')</script>");
            txt7.Text = "";
            txt8.Text = "";
            txt7.Focus();
        }
        else
        {
            txt9.Text = Convert.ToString((Convert.ToInt32(txt5.Text)) - (Convert.ToInt32(txt7.Text)));
        }
    }
    protected void txt6_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btncal_Click(object sender, EventArgs e)
    {
    //    btnsave.Visible = true;
    //    if (Convert.ToInt32(txt6.Text) < Convert.ToInt32(txt7.Text))
    //    {
    //        txt8.Text = "0";
    //    }
    //    else
    //    {
    //        txt8.Text = Convert.ToString((Convert.ToInt32(txt6.Text)) - (Convert.ToInt32(txt7.Text)));
    //    }
    //    txt9.Text = Convert.ToString((Convert.ToInt32(txt5.Text)) - (Convert.ToInt32(txt8.Text)));
    }
}

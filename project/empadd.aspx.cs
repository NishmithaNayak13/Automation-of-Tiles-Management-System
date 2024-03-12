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
public partial class empadd : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            LoadYears();
            LoadMonths();
            LoadDates();
            //Panel1.Visible = false;
            Calendar1.Visible = false;
            //txtdoj.Text = DateTime.Now.Date.ToShortDateString();
            try
            {
                c = new connect();
                int count;
                c.cmd.CommandText = "select count(*) from employeedetails";
                count = Convert.ToInt16(c.cmd.ExecuteScalar()) + 1;
                txtempno.Text = "E100" + count.ToString();
                txtempname.Focus();
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
    private void LoadYears()
    {
        DataSet dsyears = new DataSet();
        dsyears.ReadXml(Server.MapPath("~/year.xml"));
        ddlyr.DataTextField = "number";
        ddlyr.DataValueField = "value";
        ddlyr.DataSource = dsyears;
        ddlyr.DataBind();
    }
    private void LoadMonths()
    {
        DataSet dsmonths = new DataSet();
        dsmonths.ReadXml(Server.MapPath("~/month.xml"));
        ddlmt.DataTextField = "name";
        ddlmt.DataValueField = "number";
        ddlmt.DataSource = dsmonths;
        ddlmt.DataBind();
    }
    private void LoadDates()
    {
        DataSet dsdates = new DataSet();
        dsdates.ReadXml(Server.MapPath("~/date.xml"));
        //ddldt.DataTextField = "number";
        ddldt.DataValueField = "number";
        ddldt.DataSource = dsdates;
        ddldt.DataBind();
    }

    protected void btnadd_Click(object sender, EventArgs e)
    {
            try
        {
            c = new connect();
            if (txtempname.Text != "" && txtadd.Text != "" && txtemail.Text != "" && txtdob.Text != "" && txtage.Text != "" && txtdoj.Text != "" && txtsalary.Text != "")
            {
                c.cmd.CommandText = "insert into employeedetails values(@empno,@empname,@address,@phno,@designation,@email,@DOB,@age,@DOJ,@gender,@status,@salary)";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@empno", SqlDbType.NVarChar).Value = txtempno.Text;
                c.cmd.Parameters.Add("@empname", SqlDbType.NVarChar).Value = txtempname.Text;
                c.cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtadd.Text;
                c.cmd.Parameters.Add("@phno", SqlDbType.SmallInt).Value = Convert.ToInt16(txtphno.Text); 
                c.cmd.Parameters.Add("@designation", SqlDbType.NVarChar).Value = DropDownList1.SelectedItem.ToString();
                c.cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtemail.Text;
                c.cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = Convert.ToDateTime(txtdob.Text);
                c.cmd.Parameters.Add("@age", SqlDbType.BigInt).Value = Convert.ToInt32(txtage.Text);
                c.cmd.Parameters.Add("@DOJ", SqlDbType.DateTime).Value = Convert.ToDateTime(txtdoj.Text);
                c.cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = (String)Session["s"];
                c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "active";
                c.cmd.Parameters.Add("@salary", SqlDbType.BigInt).Value = Convert.ToInt32(txtsalary.Text);
                c.cmd.ExecuteNonQuery();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Record saved')</script>");
                //c.cmd.Parameters.Clear();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Enter all fields')</script>");
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
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtempname.Text = "";
        txtadd.Text = "";
        txtphno.Text = "";
        DropDownList1.SelectedIndex = 0;
        txtemail.Text = "";
        txtdob.Text = "";
        txtage.Text = "";
        txtdoj.Text = "";
        //txtstatus.Text = "";
        txtsalary.Text = "";

    }
    protected void male_CheckedChanged(object sender, EventArgs e)
    {
        Session["s"] = ((System.Web.UI.WebControls.RadioButton)sender).Text;
    }
    protected void female_CheckedChanged(object sender, EventArgs e)
    {
        Session["s"] = ((System.Web.UI.WebControls.RadioButton)sender).Text;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtsalary.Text = DropDownList1.SelectedValue.ToString();
    }
    protected void txtdoj_TextChanged(object sender, EventArgs e)
    {
        
    }
    //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    //{
    //    txtdob.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
    //    Calendar1.Visible = false;
    //    DateTime dob = Convert.ToDateTime(txtdob.Text);
    //    long age = DateTime.Now.Year - dob.Year;
    //    txtage.Text = Convert.ToString(age);
    //    //if (age < 18)
    //    //{
    //    //    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Age must be above 18 years')</script>");
    //    //    txtage.Text = "";
    //    //    txtdob.Text = "";
    //    //    txtdob.Focus();
    //    //}
    //    //if (txtdob.Text == "")
    //    //{
    //    //    Panel1.Visible = true;
    //    //}
    //    //else
    //    //{
    //    //    Panel1.Visible = false;
    //    //}
    //}
    // protected void  ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{
    //    Panel1.Visible =true ;
    //}
    protected void ddlmt_SelectedIndexChanged(object sender, EventArgs e)
    {
        int year = Convert.ToInt16(ddlyr.SelectedValue);
        int month = Convert.ToInt16(ddlmt.SelectedValue);
        int date = Convert.ToInt16(ddldt.SelectedValue);
        //Calendar1.VisibleDate = new DateTime(year, month, 1);
        //Calendar1.SelectedDate = new DateTime(year, month, 1);
    }
    protected void ddlyr_SelectedIndexChanged(object sender, EventArgs e)
    {
        int year = Convert.ToInt16(ddlyr.SelectedValue);
        int month = Convert.ToInt16(ddlmt.SelectedValue);
        int date = Convert.ToInt16(ddldt.SelectedValue);
        //Calendar1.VisibleDate = new DateTime(year, month, 1);
        //Calendar1.SelectedDate = new DateTime(year, month, 1); 
    }


    //protected void ddldt_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string dob = ddldt.SelectedItem.Text;
    //    c.cmd .CommandText ="select * from employeedetails where 
    //}
    protected void txtage_TextChanged(object sender, EventArgs e)
    {

    }
    //protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    //{
    //    Calendar2.Visible = true ;
    //}
    //protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    //{
    //    txtdoj.Text = Calendar2.SelectedDate.ToString("dd/MM/yyyy");
    //    Calendar2.Visible = true ;
    //}
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/employee.aspx");
    }
    protected void txtdob_TextChanged(object sender, EventArgs e)
    {
        
    }

   
    protected void btnset_Click(object sender, EventArgs e)
    {
        //int  yr = DateTime.Now.Hour;
        int va, s, r;
        va = Convert.ToInt16(ddldt.SelectedItem.ToString());
         s = Convert.ToInt16(28);
         r = Convert.ToInt16(29);
        int yr = Convert.ToInt16(ddlyr.SelectedItem.Text);
        if (ddlmt.SelectedItem.Text == "February")
        {
            if (yr % 4 == 0)
            {
                //int va, s, r;
                //va = Convert.ToInt16(ddldt.SelectedItem.ToString());
               // s = Convert.ToInt16(28);
               // r = Convert.ToInt16(29);
                if (va > r)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('only 29 days in this month')</script>");
                    txtdob.Text = "";
                }
            }
                else if (va > s)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('only 28 days in this month')</script>");
                    txtdob.Text = "";
                }
            
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('only 28 days in this month')</script>");

        }
        else if (ddlmt.SelectedItem.Text == "April" || ddlmt.SelectedItem.Text == "June" || ddlmt.SelectedItem.Text == "November" || ddlmt.SelectedItem.Text == "September")
        {
            int j, a;
            j = Convert.ToInt16(ddlyr.SelectedItem.ToString());
            a = Convert.ToInt16(30);
            if (j > a)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Only 30 days in this month')</script>");
                txtdob.Text = "";
            }
        }
        txtdob .Text =ddlmt.SelectedValue +"/"+ ddldt.SelectedValue +"/"+ ddlyr.SelectedValue ;
    }
    protected void btnage_Click(object sender, EventArgs e)
    {
       DateTime   dob = Convert.ToDateTime (txtdob.Text);
       long age = DateTime.Now.Year - dob.Year;
        txtage.Text = Convert.ToString(age);
        if (age < 18)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Age must be above 18 years')</script>");
            txtdob.Text = "";
        }
       
    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select count(*) from employeedetails where email='" + txtemail.Text + "'";
            int p = Convert.ToInt16(c.cmd.ExecuteScalar());
            if (p > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Email id already exists')</script>");
                txtdoj.Text = "";
                txtdoj.Focus();
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
        //txtdoj.Text = Calendar1.SelectedDate.ToShortDateString();
    }
   
    protected void txtphno_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtdoj.Text = Calendar1.SelectedDate.ToShortDateString();
    }
    protected void ddldt_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
   
}

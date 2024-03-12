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
public partial class userlogin : System.Web.UI.Page
{
    connect c = new connect();
    SqlDataAdapter adp = new SqlDataAdapter();
    DataSet ds;
    string uname, pass, status;
    // static String lockstatus;
    static int attemptcount = 0;


    protected void Page_Load(object sender, EventArgs e)
    {


        try
        {

            ds = new DataSet();
            if (DropDownList1.Items.Count == 0)
            {
                c.cmd.CommandText = "select distinct(username) from newlogin";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "reg");
                if (ds.Tables["reg"].Rows.Count > 0)
                {
                    DropDownList1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["reg"].Rows.Count; i++)
                    {
                        DropDownList1.Items.Add(ds.Tables["reg"].Rows[i].ItemArray[0].ToString());
                    }
                }
            }
            txt1.Focus();
            Panel2.Visible = false;
            if (IsPostBack)
            {
                String password = txt1.Text;
                txt1.Attributes.Add("value", password);
            }
            if (ddl1.Items.Count == 0)
            {
                c.cmd.CommandText = "select distinct(username) from newlogin";
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "r");
                if (ds.Tables["r"].Rows.Count > 0)
                {
                    ddl1.Items.Add("select");
                    int i;
                    for (i = 0; i < ds.Tables["r"].Rows.Count; i++)
                    {
                        ddl1.Items.Add(ds.Tables["r"].Rows[i].ItemArray[0].ToString());
                    }
                }
            }
            Session["user"] = ddl1.SelectedItem.Text;

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
    // protected void btnlog_Click(object sender, EventArgs e)
    // {
    //     c = new connect();
    //     ds = new DataSet();
    //     //string status = "locked";
    //     Session["user"] = ddl1.SelectedItem.Text;

    //    try
    //    {
    //        if (txt1.Text == "" && txt2.Text == "")
    //        {
    //            MessageBox.Show("enter all fields");
    //        }
    //        else
    //        {
    //            string aname = ddl1.SelectedItem.Text;
    //            string apass = txt1.Text.Trim();
    //           // Session["user"] = aname;
    //            c.cmd.CommandText = "select * from newlogin where username='" + aname + "'";
    //            adp.SelectCommand = c.cmd;
    //            ds.Clear();
    //            adp.Fill(ds, "login");
    //            if (ds.Tables["login"].Rows.Count > 0)
    //            {
    //                int count = Convert.ToInt16(ds.Tables["login"].Rows[0].ItemArray[5]);
    //                if (count >=3)
    //                {
    //                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Your account has been blocked')</script>");

    //                }
    //                else
    //                {
    //                    if (apass == ds.Tables["login"].Rows[0].ItemArray[1].ToString())
    //                    {
    //                        Session["valid"] = "y";
    //                        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Login ')</script>");
    //                        count = 0;
    //                        c.cmd.CommandText = "update newlogin set count=" + count + "where username='" + aname + "'";
    //                        c.cmd.ExecuteNonQuery();
    //                        Response.Redirect("~/newuserlog.aspx");
    //                    }
    //                    else
    //                    {
    //                        Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('wrong password')</script>");
    //                        txt1.Text = "";
    //                        count++;
    //                        if (count == 3)
    //                        {
    //                            Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('your account has been blocked')</script>");
    //                            //c.cmd.CommandText = "update newlogin set status=@status where username='" + aname + "'";
    //                        }
    //                        c.cmd.CommandText = "update newlogin set count=" + count + "where username='" + aname + "'";
    //                        c.cmd.ExecuteNonQuery();
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                MessageBox.Show("wrong username");
    //            }
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
    //                       //c.cmd .CommandText ="update newlogin set count

    //       //if (txt1.Text == "user")
    //       //{
    //       //     Response.Redirect("~/newuserlog.aspx");
    //       //}
    //       //else
    //       //{
    //       //     Session["us"] = ddl1.SelectedItem.Text;
    //       //     Session["pa"] = txt1.Text;
    //       //     c = new connect();
    //       //     ds = new DataSet();
    //       //     ds1 = new DataSet();
    //       //     c.cmd.CommandText = "select * from newlogin where username='" + ddl1.SelectedItem + "'and password='" + txt1.Text + "'";
    //       //     adp.SelectCommand = c.cmd;
    //       //     adp.Fill(ds, "reg");
    //       //     if (txt1.Text != "")
    //       //     {
    //       //         if (ds.Tables[0].Rows.Count > 0)
    //       //         {
    //       //             String stat = Convert.ToString(ds.Tables["reg"].Rows[0].ItemArray[2]);
    //       //             if (stat == "open")
    //       //             {
    //       //                 Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Login Successful')</script>");
    //       //                 c.cmd.CommandText = "select * from stock where no_of_pc<reorder";
    //       //                 adp.SelectCommand = c.cmd;
    //       //                 adp.Fill(ds1, "stk");
    //       //                 if (ds1.Tables["stk"].Rows.Count > 0)
    //       //                 {
    //       //                     Response.Redirect("~/reorder.aspx");
    //       //                 }
    //       //                 else
    //       //                 {
    //       //                     Response.Redirect("~/cssmenu.aspx");
    //       //                 }
    //       //             }
    //       //             else
    //       //             {
    //       //                 Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Your account has been locked')</script>");
    //       //             }      
    //       //         }
    //       //         else
    //       //         {
    //       //             Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Unable to login')</script>");
    //       //             txt1.Attributes["value"] = "";
    //       //             txt1.Text = "";
    //       //         }
    //       //     }
    //       //     else
    //       //     {
    //       //         Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Please enter password')</script>");
    //       //     }
    //       // }
    //       // c.cmd.CommandText ="select * from newlogin where username='" + ddl1.SelectedItem.Text +"'" + "and password='" + txt2.Text+"'";
    //       // adp .SelectCommand =c.cmd ;
    //       // adp.Fill (ds,"blk");
    //       // String uname, pas, status;
    //       // if (ds.Tables["blk"].Rows.Count > 0)
    //       // {
    //       //     uname = ds.Tables["blk"].Rows[0]["username"].ToString();
    //       //     pas= ds.Tables["blk"].Rows[0]["password"].ToString();
    //       //     status = ds.Tables["blk"].Rows[0]["lockstatus"].ToString();
    //       //     if (status == "open")
    //       //     {
    //       //         if (uname == ddl1.SelectedItem.Text && pas == txt1.Text)
    //       //         {
    //       //             Session["username"] = uname;
    //       //             Response.Redirect("~/register.aspx");
    //       //         }
    //       //         else
    //       //         {
    //       //             Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('you are locked,contact admin')</script>");
    //       //         }
    //       //     }    
    //       //     else
    //       //     {
    //       //         Label1.Text = " invalid username and password" + (2 - attemptcount);
    //       //         attemptcount = attemptcount + 1;
    //       //     }
    //       // }
    //       // if (attemptcount == 3)
    //       // {
    //       //     Label1.Text = "your account has been blocked";
    //       //     setlockstatus(ddl1.SelectedItem.Text);
    //       //     attemptcount = 0;
    //       // }
    ////    }
    ////    catch (Exception )
    ////    {
    ////        throw ;
    ////    }
    ////    finally 
    ////    {
    ////        c.cnn.Close ();
    ////    }
    ////}

    protected void btnok_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/userforgot.aspx");
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txt2.Text = "";
    }
    protected void btnhome_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel1.Visible = true;
    }
    protected void btnbck_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/register.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/userforgot.aspx");
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == false)
        {
            txt1.TextMode = TextBoxMode.Password;
        }
        if (CheckBox1.Checked == true)
        {
            txt1.TextMode = TextBoxMode.SingleLine;
        }
    }
    protected void btnlog_Click(object sender, EventArgs e)
    {
        //attemptcount = 0;
        c = new connect();
        ds = new DataSet();
        c.cmd.CommandText = "select * from newlogin where username='" + ddl1.SelectedItem.Text + "'";
        adp.SelectCommand = c.cmd;

        adp.Fill(ds, "blk");

        if (ds.Tables[0].Rows.Count > 0)
        {
            uname = ds.Tables["blk"].Rows[0]["username"].ToString();
            pass = ds.Tables["blk"].Rows[0]["password"].ToString();
            status = ds.Tables["blk"].Rows[0]["status"].ToString();
            c.cnn.Close();
            if (status == "open")
            {
                if (uname == ddl1.SelectedItem.Text && txt1.Text=="user")
                {
                     Response.Redirect("~/newuserlog.aspx");
                   // c.cmd.CommandText="update newlogin set password='" + ddl1.SelectedItem.ToString() + "'";
                }
            
                if (uname == ddl1.SelectedItem.Text && pass == txt1.Text)
                {
                    Session["username"] = uname;
                    //Response.Redirect("~/cssmenu.aspx");
                    //Response.Redirect("~/newuserlog.aspx");
                    Response.Redirect("~/homemaster.aspx");
                }
                else
                {
                    Label1.Text = " invalid username and password ...Attempt: " + (2 - attemptcount);
                    attemptcount = attemptcount + 1;
                    
                }
            }
            else
            {
                Label1.Text = "your account is blocked already contact administrator";
            }
        }
        else
        {
            Label1.Text = "invalid username or password";
        }
        if (attemptcount == 3)
        {
            Label1.Text = "your account has been blocked";
            txt1.Visible = false;
            string updatedata = "update newlogin set status='locked' where username='" + ddl1.SelectedItem.ToString() + "'";
            c.cmd.CommandText = updatedata;
            c.cnn.Open();
            c.cmd.ExecuteNonQuery();
            ddl1.Visible = false;
            txt2.Visible = false;
            btnlog.Visible = false;
            //setlockstatus(ddl1.SelectedItem.Text);
            attemptcount = 0;
        }
    }
    //    private void setlockstatus(String username)
    //{
    //   string updatedata ="update newlogin set status='locked' where username='"+username +"'";
    //   c.cmd.CommandText = updatedata;
    //    ddl1 .Visible =false ;
    //    txt2.Visible =false ;
    //    btnlog .Visible =false ;
    //     c.cmd.ExecuteNonQuery();
    //}


}
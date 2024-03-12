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

public partial class preturn : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    string billno = "BILLNO";
    protected void Page_Load(object sender, EventArgs e)
    {
        MaintainScrollPositionOnPostBack = true;
        DateTime dt = System.DateTime.Now;
        //Label2.Text = Convert.ToString(dt.Date);
        txtdate.Text = Convert.ToString(dt.Date.ToShortDateString());
        c = new connect();
        if (IsPostBack)
        {
            c.cmd.CommandText = "select count(*) from preturn";
            int i = Convert.ToInt16(c.cmd.ExecuteScalar());
            i++;
            txtret.Text = billno + i.ToString();
        }
    }
    protected void txtbillno_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtdate_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnret_Click(object sender, EventArgs e)
    {
        c = new connect();
        ds = new DataSet();
        int retno = 0;
        int no = retno + 1;

        ////int qty;
        ////qty = (Convert.ToInt16(txtqr.Text)) - (Convert.ToInt16(txtqa.Text));
        ////txtrej.Text = Convert.ToString(qty);
        ////c.cmd.CommandText = "insert into preturn values(@preturnno,@bill_no,@date,@tot_no_of_pc)";
        ////c.cmd.Parameters.Add("@preturnno", SqlDbType.NVarChar).Value = Convert.ToString(no);
        ////c.cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar).Value = txtbillno.Text;
        ////c.cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = txtbilldate.Text;
        ////c.cmd.Parameters.Add("@tot_no_of_pc", SqlDbType.SmallInt).Value = txtrej.Text;
        ////c.cmd.ExecuteNonQuery();
        ////Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "<script>alert('Returned')</script>");

  

    }
}

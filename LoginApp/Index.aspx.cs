using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DropDownList dd = new DropDownList();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack ) 
        {
            Session["fromLocation"] = "Texas";
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
       string fromLocation;
       fromLocation = DropDownList1.SelectedValue.ToString();

       Session["fromLocation"] = fromLocation;
       Response.Redirect("page2.aspx");
        }
    }

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Greetings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string fromLocation = (String) Session["fromLocation"];
        Label1.Text = "Destinations Available from " + Session["fromLocation"];

        if (fromLocation == "New York")
        {
            DropDownList2.Items.Insert(0, new ListItem("New Jersey", ""));
            DropDownList2.Items.Insert(1, new ListItem("Massachusetts", ""));
            DropDownList2.Items.Insert(2, new ListItem("Pennsylvania", ""));
            DropDownList2.Items.Insert(3, new ListItem("Connecticut", ""));
            DropDownList2.Items.Insert(4, new ListItem("Vermont", ""));
        }
       else if (fromLocation == "Texas")
        {
            DropDownList2.Items.Insert(0, new ListItem("Arkansas", ""));
            DropDownList2.Items.Insert(1, new ListItem("Louisiana", ""));
            DropDownList2.Items.Insert(2, new ListItem("Oklahoma", ""));
            DropDownList2.Items.Insert(3, new ListItem("New Mexico", ""));
        }
        else if (fromLocation == "China")
        {
            DropDownList2.Items.Insert(0, new ListItem("Qinghai", ""));
            DropDownList2.Items.Insert(1, new ListItem("Sichuan", ""));
            DropDownList2.Items.Insert(2, new ListItem("Gansu", ""));
            DropDownList2.Items.Insert(3, new ListItem("Heilongjiang", "")); 
            DropDownList2.Items.Insert(4, new ListItem("Yunnan", ""));
            DropDownList2.Items.Insert(5, new ListItem("Hunan", ""));
        }
        else if (fromLocation == "Russia")
        {
            DropDownList2.Items.Insert(0, new ListItem("Norway", ""));
            DropDownList2.Items.Insert(1, new ListItem("Finland", ""));
            DropDownList2.Items.Insert(2, new ListItem("Estonia", ""));
            DropDownList2.Items.Insert(3, new ListItem("Latvia", ""));
            DropDownList2.Items.Insert(4, new ListItem("Lithuania", ""));
            DropDownList2.Items.Insert(5, new ListItem("Poland", ""));
        }
        else if (fromLocation == "California")
        {
            DropDownList2.Items.Insert(0, new ListItem("San Francisco", ""));    
            DropDownList2.Items.Insert(1, new ListItem("Las Vegas", ""));
            DropDownList2.Items.Insert(2, new ListItem("Los Angeles", ""));
            DropDownList2.Items.Insert(3, new ListItem("Arizona", ""));
            DropDownList2.Items.Insert(4, new ListItem("Nevada", ""));
          
        }
        else
        {
            DropDownList2.Items.Insert(0, new ListItem("ERRRORRRRR!", ""));
        }




    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string toLocation;
        toLocation = DropDownList2.SelectedItem.ToString();

        Session["toLocation"] = toLocation;
        //Label1.Text = "Destinations Available from " + Session["toLocation"];
        Response.Redirect("page3.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] months = new string[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        String month = "Error!";
        string withoutNumbers = Regex.Replace(Session["date"].ToString(), "[0-9]", "");
        withoutNumbers = Regex.Replace(withoutNumbers, "[Ex-]", "");
        string numberOnly = Regex.Replace(Session["date"].ToString(), "[^0-9.]", "");
        numberOnly = Regex.Replace(numberOnly, "[Ex-]", "");
        int newDay = int.Parse(numberOnly) + 12;
        String time = Regex.Replace(Session["time"].ToString(), "[Ex-]", "");
        for (int i = 0; i <= months.Length - 1; i++)
        {
            if (months[i].ToLower().Contains(withoutNumbers.ToLower().Trim()))
            {
                if (i == months.Length - 1 && newDay > 31)
                {
                    month = months[0];
                    newDay = (newDay - 31);
                }
                else
                {
                    if (newDay > 31)
                    {
                        newDay = (newDay - 31);
                        month = months[i + 1];
                    }
                    else
                        month = months[i];
                }
                   
            }
        }




        //Label1.Text = "Your flight leaves at " + Session["time"] + " from " + Session["fromLocation"] + " and Arrives in " + Session["toLocation"] + " on " +
        //   withoutNumbers + " " + months[10] + " " + newDay;

        if (Session["trip"].ToString().Contains("Round"))
        {
            Label1.Text = "Your " + Session["trip"] + " flight leaves at " + time + " from " + Session["fromLocation"] + " and Arrives in " + Session["toLocation"] + " on " + month + " " + newDay + ".";

            Label2.Text = "Your Next flight back will depart one month from " + month + ".";
        }
        else if (Session["trip"].ToString().Contains("One"))
            Label1.Text = "Your " + Session["trip"] + " flight leaves at " + time + " from " + Session["fromLocation"] + " and Arrives in " + Session["toLocation"] + " on " + month + " " + newDay + ".";
        else
            Label1.Text = "Your flight leaves at " + time + " from " + Session["fromLocation"] + " and Arrives in " + Session["toLocation"] + " on " + month + " " + newDay +".";
    }
}
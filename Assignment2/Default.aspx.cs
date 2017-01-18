using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] myEvent= new string[6,2];
         
    protected void Page_Load(object sender, EventArgs e)
    {
        myEvent[0, 0] = "2/20/2017";
        myEvent[0, 1] = "Friend's Birthday ";
        myEvent[1, 0] = "2/20/2017";
        myEvent[1, 1] = "Presidents'Day ";
        myEvent[2, 0] = "5/29/2017";
        myEvent[2, 1] = "Memorial Day ";
        myEvent[3, 0] = "7/4/2017";
        myEvent[3, 1] = "Independence Day ";
        myEvent[4, 0] = "9/4/2017";
        myEvent[4, 1] = "Labor Day ";
        myEvent[5, 0] = "11/23/2017";
        myEvent[5, 1] = "Thanksgiving Day ";
       
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
       
        Label1.Text = "Selected date is: " + Calendar1.SelectedDate.ToShortDateString();
        
        for (int i = 0; i < 6; i++)
        {
            if (Calendar1.SelectedDate.ToShortDateString() == myEvent[i, 0])
            {
                Label1.Text +=  " </br>" + myEvent[i, 1];
            }
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using eRestaurantSystem.BLL; //controller
using eRestaurantSystem.DAL.Entities; //entity
using EatIn.UI;//messageusercontrol
#endregion

public partial class ComandPages_WaiterAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //initialize date hired to today.
        DateHired.Text = DateTime.Today.ToShortDateString();

    }

    protected void FetchWaiter_Click(object sender, EventArgs e)
    {
        if (WaiterList.SelectedIndex == 0)
            MessageUserControl1.ShowInfo("Please select a waiter before clicking Fetch Waiter.");
        else
            //we will use a TryCatch() from the MessageUserControl. This will capture error messages when/if they happen, and properly display in the user control.
            MessageUserControl1.TryRun((ProcessRequest)GetWaiterInfo);

        public void GetWaiterInfo()
        {
            AdminController sysmgr = new AdminController();
            var waiter = sysmgr.GetWaiterByID(int.Parse(WaiterList.SelectedValue));
            WaiterID.Text = waiter.WaiterID.ToString();
            FirstName.Text = waiter.FirstName;
            LastName.Text = waiter.LastName;
            Phone.Text = waiter.Phone;
            Address.Text = waiter.Address;
            DateHired.Text = waiter.HireDate.ToShortDateString();
            if (waiter.ReleaseDate.hasValue)
                DateReleased = waiter.ReleaseDate.ToShortDateString();
        }
    }
}
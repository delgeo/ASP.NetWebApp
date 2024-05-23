using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentWebApplication
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelCounter.Text = "You are visitor no. " + Application["Counter"].ToString();
            
            if (Session["UserID"] == null)
            {
                LoginButton.Visible = true;
                LogoutButton.Visible = false;
            }
            else
            {
                LoginButton.Visible = false;
                LogoutButton.Visible = true;
            }

            AsgmtSettings Settings = (AsgmtSettings)Application["Settings"];
            HeaderText.Text = Settings.HeaderText;
            FooterText.Text = Settings.FooterText;

        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsgmtLogin.aspx");   
        }
        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Response.Redirect("Default.aspx");
        }
    }
}
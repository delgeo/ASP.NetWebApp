using AssignmentWebApplication.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentWebApplication
{
    public partial class AsgmtAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Default.aspx");
            }

            if (!IsPostBack)
            {
                AsgmtSettings Settings = (AsgmtSettings)Application["Settings"];
                TextBoxDefaultPageText1.Text = Settings.DefaultPageText1;
                TextBoxDefaultPageText2.Text = Settings.DefaultPageText2;
                HeaderText.Text = Settings.HeaderText;
                FooterText.Text = Settings.FooterText;
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            AsgmtSettings Settings = (AsgmtSettings)Application["Settings"];
            Settings.DefaultPageText1 = TextBoxDefaultPageText1.Text;
            Settings.DefaultPageText2 = TextBoxDefaultPageText2.Text;
            Settings.HeaderText = HeaderText.Text;
            Settings.FooterText = FooterText.Text;
            AsgmtManager.SaveSettings(Server.MapPath("~/App_Data/Settings.xml"),Settings);
            Application["Settings"] = Settings;
        }
    }
}
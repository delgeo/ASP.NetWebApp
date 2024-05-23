using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*try
            {
                AsgmtSettings Settings = (AsgmtSettings)Application["Settings"];
                LabelDefaultText1.Text = Settings.DefaultPageText1;
                //LabelDefaultText2.Text = Settings.DefaultPageText2;
            }
            catch (Exception)
            {

            }
        }
    }*/

            if (!IsPostBack)
            {
                // Initial load, set the state to "text1" if not already set
                if (Session["ToggleState"] == null)
                {
                    Session["ToggleState"] = "text1";
                }
                ToggleSettingsValue();
            }
            else
            {
                // On refresh or postback, toggle the value
                ToggleSettingsValue();
            }
        }

        private void ToggleSettingsValue()
        {
            if (Session["ToggleState"] != null && Session["ToggleState"].ToString() == "text1")
            {
                Session["ToggleState"] = "text2";
            }
            else
            {
                Session["ToggleState"] = "text1";
            }
            UpdateSettingsValue();
        }

        private void UpdateSettingsValue()
        {
            AsgmtSettings Settings = (AsgmtSettings)Application["Settings"];
            if (Session["ToggleState"] != null && Session["ToggleState"].ToString() == "text1")
            {
                LabelDefaultText1.Text = Settings.DefaultPageText1;
            }
            else
            {
                LabelDefaultText1.Text = Settings.DefaultPageText2;
            }
        }
    }

    public class Settings
    {
        public string text1 { get; set; } = "Value Text1";
        public string text2 { get; set; } = "Value Text2";
    }
}
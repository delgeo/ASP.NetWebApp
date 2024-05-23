using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentWebApplication
{
    public partial class AsgmtLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["PFUserName"];
            string Password = WebConfigurationManager.AppSettings["PFPassword"];
            if (TextBoxEmail.Text == UserName && TextBoxPassword.Text == Password)
            {
                Session.Add("UserID", UserName);
                Response.Redirect("AsgmtAdmin.aspx");
            }
            else
            {
                LabelMessage.Text = "Please Enter Valid Username and Password!";
            }
        }
    }
}
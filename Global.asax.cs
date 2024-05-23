using AssignmentWebApplication.App_Start;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using static AssignmentWebApplication.App_Start.AsgmtManager;

namespace AssignmentWebApplication
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Application.Add("Key", "12345");
            //string Key = (string)Application["Key"];
            //if (!File.Exists(Server.MapPath("~/App_Data/Settings.xml")))
            //{
            //   File.Create(Server.MapPath("~/App_Data/Settings.xml"));
            //}

            if (File.Exists(Server.MapPath("~/App_Data/Settings.xml"))) { 
                AsgmtSettings Settings = AsgmtManager.LoadSettings(Server.MapPath("~/App_Data/Settings.xml"));
                Application.Add("Settings", Settings);
            }

            
        }
        void Session_Start(Object sender, EventArgs e)
        {
            if (Application["Counter"] == null)
            {
                Application.Add("Counter", 0);
            }
            int iCounter = Convert.ToInt32(Application["Counter"]);
            iCounter++;
            Application["Counter"] = iCounter.ToString();

        }
    }
}
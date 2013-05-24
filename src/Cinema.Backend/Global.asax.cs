using System;
using System.Data.Entity;
using System.Web;

using Cinema.Entity;

namespace Cinema.Backend
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            CreateDatabaseAndPopulateData();
            new AppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private void CreateDatabaseAndPopulateData()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
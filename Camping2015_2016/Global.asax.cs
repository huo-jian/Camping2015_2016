using Camping2015_2016.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Camping2015_2016
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            
            IDatabaseInitializer<BddContext> init = new InitialiseCamping();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
            
        }
    }
}

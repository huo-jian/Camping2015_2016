using Camping2015_2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camping2015_2016.Controllers
{
    public class IndexController : Controller
    {
        

        public ActionResult Index()
        {

            return View();
            
        }

        public ActionResult Contact()
        {
            return View();
        }

  
    }
}
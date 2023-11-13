using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TheCoffeeHouse_TCH.Models;


namespace TheCoffeeHouse_TCH.Controllers
{
    public class HomeController : Controller
    {
        QL_TCHEntities db= new QL_TCHEntities();    
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();  
        }

    }

}

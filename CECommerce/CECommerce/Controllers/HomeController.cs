namespace CECommerce.Controllers
{
    using CECommerce.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private CECommerceContext dab = new CECommerceContext();

        public ActionResult Index()
        {
            var user = 
                dab.Users.Where(
                us => us.UserName == User.Identity.Name).
                FirstOrDefault();

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AzureADAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // Check
            var isAuth = User.Identity.IsAuthenticated;

            var identity = (ClaimsIdentity)User.Identity;
            var emailClaim = identity.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week4_day3_paired.Models;

namespace week4_day3_paired.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<WorkItem> BugsTaks = new List<WorkItem> {
                new Task(" Fix Potential Security Exposures ", DateTime, "High"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime, "Low"),
                new Task(" Improve Power Comsumption, Battery Life ", DateTime, "Medium"),
                new Bug("iMovie 9.0.8 fails with error when exporting to QuickTime ", DateTime, "Low"),
                new Bug("OS X 10.8.3 (12D78): Photo app crashed ", DateTime, "Low"),
                new Task(" New Feature ", DateTime, "Low"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime, "Low"),
                new Task(" Fix comestic issues ", DateTime, "Low"),
                new Task(" Improve responsiveness of app ", DateTime, "Medium"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iMail ", DateTime, "Low"),
                new Task(" Improve new feature ", DateTime, "Low"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime, "Low"),

            };

            return View();
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
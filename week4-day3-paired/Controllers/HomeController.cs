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
            List<WorkItem> BugsTasks = new List<WorkItem> {
                new TaskTodo(" Fix Potential Security Exposures ", DateTime.Now, "High"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime.Now, "Low"),
                new TaskTodo(" Improve Power Comsumption, Battery Life ", DateTime.Now, "Medium"),
                new Bug("iMovie 9.0.8 fails with error when exporting to QuickTime ", DateTime.Now, "Low"),
                new Bug("OS X 10.8.3 (12D78): Photo app crashed ", DateTime.Now, "Low"),
                new TaskTodo(" New Feature ", DateTime.Now, "Low"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime.Now, "Low"),
                new TaskTodo(" Fix comestic issues ", DateTime.Now, "Low"),
                new TaskTodo(" Improve responsiveness of app ", DateTime.Now, "Medium"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iMail ", DateTime.Now, "Low"),
                new TaskTodo(" Improve new feature ", DateTime.Now, "Low"),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime.Now, "Low"),

            };

            return View(BugsTasks);
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
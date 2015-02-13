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
        List<WorkItem> BugsTasks = new List<WorkItem> {
                new TaskTodo(" Fix Potential Security Exposures ", DateTime.Now, "High", 1),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime.Now, "Low", 2),
                new TaskTodo(" Improve Power Comsumption, Battery Life ", DateTime.Now, "Medium", 3),
                new Bug("iMovie 9.0.8 fails with error when exporting to QuickTime ", DateTime.Now, "Low", 4),
                new Bug("OS X 10.8.3 (12D78): Photo app crashed ", DateTime.Now, "Low", 5),
                new TaskTodo(" New Feature ", DateTime.Now, "Low", 6),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime.Now, "Low", 7),
                new TaskTodo(" Fix comestic issues ", DateTime.Now, "Low", 8),
                new TaskTodo(" Improve responsiveness of app ", DateTime.Now, "Medium", 9),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iMail ", DateTime.Now, "Low", 10),
                new TaskTodo(" Improve new feature ", DateTime.Now, "Low", 11),
                new Bug("OS X 10.8.3 (12D78): Finder crashed connecting to iCloud ", DateTime.Now, "Low", 12)

            };

        public ActionResult Index()
        {
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

        public ActionResult Details(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index"); 
            {
                WorkItem model = BugsTasks.Where(x => x.ID == id).FirstOrDefault();

                return View(model);
            }
        }

        public ActionResult ShowBugs()
        {
            List<Bug> model = new List<Bug>();
            foreach (var bug in BugsTasks )
            {
                if ( CharacterType.Bug )
)

            }
        }
    }
}
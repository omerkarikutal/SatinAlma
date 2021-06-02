using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SatinAlma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new OBA_ELEKTRAEntities())
            {
                var currentUser = Session["user"] as USER;
                var list = context.QMUH_SATINALMA.Where(s => s.DURUMID < 18 && s.DURUMID != 12).ToList();
                return View(list);
            }
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
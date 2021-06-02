using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SatinAlma.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        //Action
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            using (var context = new OBA_ELEKTRAEntities())
            {
                var user = context.USER.Where(s => s.KODU == username && s.SIFRESI == password).FirstOrDefault();

                if (user != null)
                {
                    Session["user"] = user;
                    return RedirectToAction("Index", "Home");
                }
                return Json(null);
            }
        }
    }
}
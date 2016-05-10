using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using chart.lib;

namespace chart.mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult ShowChart(int id)
        {
            //TODO: get from db i guess
            DataModel dm = new DataModel();
            Chart c = dm.Charts.First();
            return View(c);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
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
        public ActionResult InstRental()
        {
            return View();
        }
        public ActionResult ItemRental(string name)
        {
            ViewBag.name = name;
            ViewBag.image = "../Content/Images/"+name+".png";

            if (name == "Trumpet")
            {
                ViewBag.newprice = "$55 a month";
                ViewBag.usedprice = "$25 a month";
            }
            if (name == "Trombone")
            {
                ViewBag.newprice = "$60 a month";
                ViewBag.usedprice = "$35 a month";
            }
            if (name == "Tuba")
            {
                ViewBag.newprice = "$70 a month";
                ViewBag.usedprice = "$50 a month";
            }
            if (name == "Flute")
            {
                ViewBag.newprice = "$40 a month";
                ViewBag.usedprice = "$25 a month";
            }
            if (name == "Clarinet")
            {
                ViewBag.newprice = "$35 a month";
                ViewBag.usedprice = "$27 a month";
            }
            if (name == "Saxophone")
            {
                ViewBag.newprice = "$42 a month";
                ViewBag.usedprice = "$30 a month";
            }
            return View();
        }

    }
}
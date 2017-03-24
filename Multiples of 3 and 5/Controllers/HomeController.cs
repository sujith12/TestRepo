using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Multiples_of_3_and_5.Controllers
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

        public ActionResult Multiple()
        {
           
            List<int> list = new List<int>();
            List<int> newlist = new List<int>();
            for (int i = 1; i <= 999; i++)
                list.Add(i);

            foreach ( var j in list)
                {
                    if (j % 3 == 0 || j % 5 == 0)
                    {
                        newlist.Add(j);
                        int sum = newlist.Sum();
                    ViewBag.Result = sum;
                    }
                }
            return View();
        }

    }
}
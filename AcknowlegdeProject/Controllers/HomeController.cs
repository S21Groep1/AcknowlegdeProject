using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcknowlegdeProject.Controllers
{
    public class HomeController : Controller
    {
        // Returns .../Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // Returns .../Home/Homepage
        public ActionResult Homepage()
        {
            return View();
        }

        // Returns .../Home/Reset
        public ActionResult Reset()
        {
            return View();
        }

        //Returns .../Home/MyAccount
        public ActionResult MyAccount()
        {
            return View();
        }

        //Returns .../Home/Page
        public ActionResult Page()
        {
            return View();
        }

        //Returns .../Home/StarrList
        public ActionResult StarrList()
        {
            return View();
        }

        //Returns .../Home/Actiepunten
        public ActionResult Actiepunten()
        {
            return View();
        }

        //Returns .../Home/StarrPage
        public ActionResult StarrPage()
        {
            return View();
        }
    }
}
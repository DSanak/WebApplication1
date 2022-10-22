using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Logowanie";

            return View("Logowanie");
        }


        /*public string Get(int id)
        {

            var a = "Zalogwoano";
            return a;
        }*/
    }
}
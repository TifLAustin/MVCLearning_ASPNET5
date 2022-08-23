using Food.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food.WebUI.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            //get text from app settings in web.config
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}
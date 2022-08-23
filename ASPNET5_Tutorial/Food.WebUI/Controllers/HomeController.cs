using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Data.Services;

namespace Food.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //Attach to database (models)
        private IRestaurantData _db;

        public HomeController(IRestaurantData db)
        {
            // create new db of specified type - replace with dependency injection
            _db = db;
        }

        //Handles what is returned on home page load
        public ActionResult Index()
        {
            //build the model required for the view here in the controller
            var model = _db.GetAll();

            //instead of returning string of HTML - return a View (declared in views folder -> [controler name] -> and then .cshtml that matches the function name here
            return View(model);
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
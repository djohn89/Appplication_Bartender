using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Appplication_Bartender.Models;


namespace Appplication_Bartender.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }


        [HttpGet]
        public ViewResult MenuForm()
        {

            return View();


        }

        [HttpPost]
        public ActionResult MenuForm(Customer customer1)
        {

            if (ModelState.IsValid)
            {
                using (CustomerDBContext dba = new CustomerDBContext())
                {
                    dba.customer.Add(customer1);
                    dba.SaveChanges();
                }
                //send request to bartender
                return View("Thanks", customer1);

            }
            else
            {
                //there is a validation error
            }
            return View();
        }

      

        public ActionResult Thanks()
        {

            return View();
        }
    }
}

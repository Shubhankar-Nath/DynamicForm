using DynamicForm.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(List<PassengerModel> passengerModelList)
        {
            var dropDown = new List<string>()
            {
                "ABC",
                "CDE",
                "EFG"
            };
            foreach(string x in dropDown)
            {
                Console.WriteLine(x);
            }
            if( passengerModelList!= null) 
            {
                return View("PassengerView",passengerModelList);
            }
            ViewBag.DropDown = dropDown;
            return View();
        }
    }
}
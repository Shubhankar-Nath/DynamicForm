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
            if( passengerModelList!= null) 
            {
                return View("PassengerView",passengerModelList);
            }
            return View();
        }
    }
}
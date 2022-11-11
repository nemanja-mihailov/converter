using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("~/ Views / Index / Index.cshtml", new CalcModel());
        }
        [HttpPost]
       public ActionResult Index(CalcModel calcModel)
        {
            double euro = calcModel.dinar / 118;
            calcModel.euro = euro;
            ModelState.Clear();

            return View("~/Views/Index/Index.cshtml", calcModel);
            
        }
       



      
    }
}
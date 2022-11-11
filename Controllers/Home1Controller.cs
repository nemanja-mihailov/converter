using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View("~/Views/Index/Index.cshtml", new CalcModel());
        }
        [HttpPost]
        public ActionResult Index(CalcModel calcModel)
        {
            double dinar1 = calcModel.euro1 * 120;
            calcModel.dinar1 = dinar1;
            ModelState.Clear();

            return View("~/Views/Index/Index.cshtml", calcModel);

        }
    }
}
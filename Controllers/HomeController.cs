using ConvertorEDDE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConvertorEDDE.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View("Index", new ConvertModel());
        }
        [HttpPost]
        public ActionResult ConvertToEuro(ConvertModel convertModel)
        {
            double euro = convertModel.broj / 118;
            convertModel.euro = euro;
            ModelState.Clear();
            return View("Index", convertModel);

        }
        [HttpPost]
        public ActionResult ConvertToDinar(ConvertModel convertModel)
        {
            double dinar = convertModel.broj * 118;
            convertModel.dinar = dinar;
            ModelState.Clear();
            return View("Index", convertModel);
        }
    }
}
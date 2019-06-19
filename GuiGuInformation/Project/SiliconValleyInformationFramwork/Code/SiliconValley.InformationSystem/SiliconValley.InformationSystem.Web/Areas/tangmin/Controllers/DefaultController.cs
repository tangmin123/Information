using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiliconValley.InformationSystem.Web.Areas.tangmin.Controllers
{
    public class DefaultController : BaseMvcController
    {
        // GET: tangmin/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}
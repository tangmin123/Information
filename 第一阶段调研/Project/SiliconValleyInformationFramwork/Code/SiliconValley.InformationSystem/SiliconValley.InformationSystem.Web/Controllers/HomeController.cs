using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiliconValley.InformationSystem.Business;

namespace SiliconValley.InformationSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Business.Base_SysManage.Base_UserBusiness buser = new Business.Base_SysManage.Base_UserBusiness();
            // var list= buser.GetList();
            //return View(list);
            Business.Base_SysManage.Base_SysRoleBusiness brole = new Business.Base_SysManage.Base_SysRoleBusiness();
            var list = brole.GetList();
            return View(list);
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
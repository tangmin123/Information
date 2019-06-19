using System.Web.Mvc;

namespace SiliconValley.InformationSystem.Web.Areas.tangmin
{
    public class tangminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "tangmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "tangmin_default",
                "tangmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
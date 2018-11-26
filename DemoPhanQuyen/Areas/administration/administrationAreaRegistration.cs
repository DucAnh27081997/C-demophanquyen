using System.Web.Mvc;

namespace DemoPhanQuyen.Areas.administration
{
    public class administrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "administration_default",
                "Admin/{controller}/{action}/{id}",
                new { Controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
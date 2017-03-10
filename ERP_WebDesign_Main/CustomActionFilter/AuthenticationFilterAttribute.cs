using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ERP_WebDesign_Main.Controllers
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Model_BL.User_BL.Users_BL objUserBL = new Model_BL.User_BL.Users_BL();
            var controller = (BaseController)filterContext.Controller;
            if (!objUserBL.IsAuthenticated())
                filterContext.Result = controller.RedirectToAction("Login", "Home");

        }
    }
}
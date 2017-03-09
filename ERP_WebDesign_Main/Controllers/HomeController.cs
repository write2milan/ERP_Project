using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ERP_WebDesign_Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User_Model.USER_LOGIN_MODEL objUserModel)
        {
            Model_BL.User_BL.Users_BL objUserBL = new Model_BL.User_BL.Users_BL();
            if (ModelState.IsValid)
            {
                if (objUserBL.IsValid(objUserModel.USERNAME, objUserModel.PASSWORD))
                {
                    FormsAuthentication.SetAuthCookie(objUserModel.USERNAME, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(objUserModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }
    }
}
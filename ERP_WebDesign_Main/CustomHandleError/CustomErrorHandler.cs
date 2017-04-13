using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.CustomHandleError
{
    public class CustomErrorHandler : HandleErrorAttribute
    {
        private bool IsAjax(ExceptionContext filterContext)
        {
            return filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled || !filterContext.HttpContext.IsCustomErrorEnabled)
            {
                return;
            }

            // if the request is AJAX return JSON else view.
            if (IsAjax(filterContext))
            {
                //Because its a exception raised after ajax invocation
                //Lets return Json
                var partialView = new PartialViewResult()
                {
                    ViewName = "Error"
                };
                partialView.ViewBag.Exception = filterContext.Exception;
                filterContext.ExceptionHandled = true;
                filterContext.Result = partialView;
                filterContext.HttpContext.Response.Clear();
                //filterContext.HttpContext.Response.StatusCode = 500;

            }
            else
            {
                //Normal Exception
                //So let it handle by its default ways.
                base.OnException(filterContext);

            }

            // Write error logging code here if you wish.
            CommonHelper.CommonHelper.ExceptionLogger(filterContext.Exception);
            //if want to get different of the request
            //var currentController = (string)filterContext.RouteData.Values["controller"];
            //var currentActionName = (string)filterContext.RouteData.Values["action"];
        }
    }
}
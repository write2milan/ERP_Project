using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomHandleError.CustomErrorHandler());
        }
    }
}

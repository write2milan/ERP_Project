using ERP_WebDesign_Main.Model_Entity_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.CommonHelper
{
    public static class CommonHelper
    {
        public static string CurrentUserLoginName()
        {
            return System.Web.HttpContext.Current.User.Identity.Name;
        }

        public static Dictionary<string, string> GetValidationErrorsFromModel(ModelStateDictionary objModel)
        {
            Dictionary<string, string> errors = new Dictionary<string, string>();
            try
            {
                objModel.Where(each => each.Value.Errors.Count > 0).ToList().ForEach(item =>
                {
                    errors.Add(item.Key, item.Value.Errors[0].ErrorMessage);
                });
            }
            catch (Exception)
            {
                throw;
            }
            return errors;
        }

        public static void ExceptionLogger(Exception exp)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objContext.tbl_ExceptionLogger.Add(new tbl_ExceptionLogger
                    {
                        EXCEPTIONMESSAGE = exp.Message,
                        EXCEPTIONSOURCE = exp.Source,
                        EXCEPTIONSTACKTRACE = exp.StackTrace,
                        LOGTIME = DateTime.Now,
                        USERID = System.Web.HttpContext.Current.User.Identity.Name
                    });
                    objContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
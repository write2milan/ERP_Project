using ERP_WebDesign_Main.Model_Entity_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.User_BL
{
    public class Users_BL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        /// <returns></returns>
        public bool IsValid(string _username, string _password)
        {
            bool isValid = false;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    var userExist = objContext.tbl_User.Where(item =>
                    item.USERNAME.Equals(_username, StringComparison.CurrentCultureIgnoreCase)
                    && item.PASSWORD.Equals(_password));
                    isValid = userExist.Count() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {

            }


            return isValid;

        }
    }
}
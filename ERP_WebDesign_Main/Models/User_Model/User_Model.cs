using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.User_Model
{
    public class User_Model
    {
        

    }

    public class USER_LOGIN_MODEL
    {
        [Required(ErrorMessageResourceType =typeof(ERP_WebDesign_UsersResource),ErrorMessageResourceName = "VALIDATION_EMPTY_USERNAME")]
        public string USERNAME { get; set; }
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_UsersResource), ErrorMessageResourceName = "VALIDATION_EMPTY_PASSWORD")]
        public string PASSWORD { get; set; }
    }
}
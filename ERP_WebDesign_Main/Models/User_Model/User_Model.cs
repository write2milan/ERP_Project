﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.User_Model
{
    public class User_Model
    {
        USER_LOGIN_MODEL aa = new USER_LOGIN_MODEL();

    }

    public class USER_LOGIN_MODEL
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
    }
}
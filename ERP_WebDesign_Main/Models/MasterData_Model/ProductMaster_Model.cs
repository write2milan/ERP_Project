using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class ProductMaster_Model : Base_Model
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }

    }
}
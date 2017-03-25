using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ERP_WebDesign_Main.Resources;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class ProductMaster_Model : Base_Model
    {
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "PRODUCT_ID")]
        public string ProductID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "PRODUCT_NAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "PRODUCT_NAME_NOTBLANK")]
        public string ProductName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "PRODUCT_DESC")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "PRODUCT_DESC_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string ProductDesc { get; set; }
    }

}
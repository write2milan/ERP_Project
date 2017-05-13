using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class ProductionUnitMaster_Model : Base_Model
    {
        [Key]
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SITE_Name")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "SITE_NAME_NOTBLANK")]
        public string Site { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LOCATION_NAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LOCATION_NAME_NOTBLANK")]
        public string Location { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LOCATION_ADDR")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LOCATION_ADDR_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        
    }
}
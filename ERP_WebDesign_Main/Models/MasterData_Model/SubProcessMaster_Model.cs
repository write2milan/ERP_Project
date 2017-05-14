using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class SubProcessMaster_Model : Base_Model
    {
        [Key]
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SUBPROCESS_ID")]        
        public string SubProcessID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SUBPROCESS_NAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "SUBPROCESS_NAME_NOTBLANK")]
        public string SubProcessName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SUBPROCESS_DESC")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "SUBPROCESS_DESC_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string SubProcessDesc { get; set; }
    }
}
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class ProcessMaster_Model : Base_Model
    {
        [Key]
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "PROCESS_ID")]
        public string ProcessID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "PROCESS_Name")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "PROCESS_NAME_NOTBLANK")]
        public string ProcessName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "PROCESS_DESC")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "PROCESS_DESC_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string ProcessDesc { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SITE_Name")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "SITE_NAME_NOTBLANK")]
        public string Site { get; set; }
        public List<SelectListItem> Sites { get; set; }
    }
}
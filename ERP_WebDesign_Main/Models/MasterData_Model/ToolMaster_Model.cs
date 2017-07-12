using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class ToolMaster_Model : Base_Model
    {
        [Key]
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "Tool_ID")]
        public string ToolID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "Tool_NAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "Tool_NAME_NOTBLANK")]
        public string ToolName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "Tool_DESC")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "Tool_DESC_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string ToolDesc { get; set; }
    }
}
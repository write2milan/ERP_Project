using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class RackMaster_Model : Base_Model
    {
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "RACK_ID")]
        public string RackID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "RACK_CODE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "RACK_CODE_NOTBLANK")]
        [StringLength(CommonHelper.Constants.STRING_MAXLENGTH_50, ErrorMessageResourceType = typeof(ERP_WebDesign_CommonResource), ErrorMessageResourceName = "STRING_LIMIT_50_MESSAGE")]
        public string RackCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "RACK_DISPLAYNAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "RACK_DISPLAYNAME_NOTBLANK")]
        [StringLength(CommonHelper.Constants.STRING_MAXLENGTH_200, ErrorMessageResourceType = typeof(ERP_WebDesign_CommonResource), ErrorMessageResourceName = "STRING_LIMIT_200_MESSAGE")]
        public string RackDisplayName { get; set; }
    }
}
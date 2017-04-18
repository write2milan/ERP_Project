using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class GroupsMaster_Model : Base_Model
    {
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "GROUP_ID")]
        public string GroupID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "GROUP_CODE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "GROUP_CODE_NOTBLANK")]
        [StringLength(CommonHelper.Constants.STRING_MAXLENGTH_50, ErrorMessageResourceType = typeof(ERP_WebDesign_CommonResource), ErrorMessageResourceName = "STRING_LIMIT_50_MESSAGE")]
        public string GroupCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "GROUP_DISPLAYNAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "GROUP_DISPLAYNAME_NOTBLANK")]
        [StringLength(CommonHelper.Constants.STRING_MAXLENGTH_200, ErrorMessageResourceType = typeof(ERP_WebDesign_CommonResource), ErrorMessageResourceName = "STRING_LIMIT_200_MESSAGE")]
        public string GroupDisplayName { get; set; }
    }
}
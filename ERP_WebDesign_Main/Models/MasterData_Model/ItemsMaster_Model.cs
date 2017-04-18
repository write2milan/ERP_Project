using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class ItemsMaster_Model : Base_Model
    {
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "ITEM_ID")]
        public string ItemID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "ITEM_CODE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "ITEM_CODE_NOTBLANK")]
        [StringLength(CommonHelper.Constants.STRING_MAXLENGTH_50, ErrorMessageResourceType = typeof(ERP_WebDesign_CommonResource), ErrorMessageResourceName = "STRING_LIMIT_50_MESSAGE")]
        public string ItemCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "ITEM_DISPLAYNAME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "ITEM_DISPLAYNAME_NOTBLANK")]
        [StringLength(CommonHelper.Constants.STRING_MAXLENGTH_200, ErrorMessageResourceType = typeof(ERP_WebDesign_CommonResource), ErrorMessageResourceName = "STRING_LIMIT_200_MESSAGE")]
        public string ItemDisplayName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "GROUP_ID")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "GROUP_ID_NOTBLANK")]
        public string GroupID { get; set; }
        public List<SelectListItem> Groups { get; set; }
    }
}
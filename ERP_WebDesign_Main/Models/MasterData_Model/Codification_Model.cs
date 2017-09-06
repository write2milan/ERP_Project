using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class Codification_Model : Base_Model
    {
        public Codification_Model()
        {
            ValidationMessageForDropdowns = ERP_WebDesign_MasterModelResource.CODI_VALIDATION_DDMESSAGE;
        }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_ID")]
        public string CodificationID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_CODE")]
        public string CodificationCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_ITEM")]
        public string ItemID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_GROUP")]
        public string GroupID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_SPEC")]
        public string SpecificationID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_RACK")]
        public string RackID { get; set; }

        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "ITEM_DISPLAYNAME")]
        public string ItemDisplayName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "ITEM_CODE")]
        public string ItemCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "GROUP_DISPLAYNAME")]
        public string GroupDisplayName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "GROUP_CODE")]
        public string GroupCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SPEC_DISPLAYNAME")]
        public string SpecificationDisplayName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "SPEC_CODE")]
        public string SpecificationCode { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "RACK_DISPLAYNAME")]
        public string RackDisplayName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "RACK_CODE")]
        public string RackCode { get; set; }
        public List<CodificationSelectListItem> Items { get; set; }
        public List<CodificationSelectListItem> Groups { get; set; }
        public List<CodificationSelectListItem> Specifications { get; set; }
        public List<CodificationSelectListItem> Racks { get; set; }
        public string ValidationMessageForDropdowns { get; set; }

    }

    public class CodificationFilterItems
    {
        public List<CodificationSelectListItem> Items { get; set; }
        public List<CodificationSelectListItem> Groups { get; set; }
        public List<CodificationSelectListItem> Specifications { get; set; }
        public List<CodificationSelectListItem> Racks { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_ITEM")]
        public string ItemID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_GROUP")]
        public string GroupID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_SPEC")]
        public string SpecificationID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "CODI_RACK")]
        public string RackID { get; set; }
    }

    public class CodificationSelectListItem
    {
        public string DisplayText { get; set; }
        public string Value { get; set; }
        public string Code { get; set; }
    }

    public class Codification
    {
        public Codification()
        {
            NoRecordFound = ERP_WebDesign_CommonResource.CODI_VALIDATION_NORECORDFOUND;
        }
        public List<Codification_Model> Collection { get; set; }
        public int ItemCount { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string NoRecordFound { get; set; }

    }

    public class CodificationWrapper
    {
        public Codification Codi { get; set; }
        public CodificationFilterItems CodiFilterItems { get; set; }
    }
}

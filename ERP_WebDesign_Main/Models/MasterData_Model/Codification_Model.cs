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
        public List<CodificationSelectListItem> Items { get; set; }
        public List<CodificationSelectListItem> Groups { get; set; }
        public List<CodificationSelectListItem> Specifications { get; set; }
        public List<CodificationSelectListItem> Racks { get; set; }

    }

    public class CodificationSelectListItem
    {
        public string DisplayText { get; set; }
        public string Value { get; set; }
        public string Code { get; set; }
    }
}
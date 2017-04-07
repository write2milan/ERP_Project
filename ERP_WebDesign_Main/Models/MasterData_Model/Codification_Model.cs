using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class Codification_Model : Base_Model
    {
        public string CodificationID { get; set; }
        public string CodificationCode { get; set; }
        public string ItemID { get; set; }
        public string GroupID { get; set; }
        public string SpecificationID { get; set; }
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
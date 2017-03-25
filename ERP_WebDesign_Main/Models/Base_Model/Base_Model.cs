using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models
{
    public class Base_Model
    {
        [Display(ResourceType = typeof(ERP_WebDesign_CommonResource), Name = "CREATED_BY")]
        public string CreatedBy { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_CommonResource), Name = "CREATED_DATE")]
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_CommonResource), Name = "MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_CommonResource), Name = "MODIFIED_DATE")]
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    }
}
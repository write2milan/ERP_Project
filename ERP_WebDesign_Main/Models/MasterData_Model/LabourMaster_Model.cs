using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class LabourMaster_Model : Base_Model
    {
        [Key]
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_ID")]
        public string LabourID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_Name")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_NAME_NOTBLANK")]
        public string Name { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_ADDR")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_ADDR_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_CONTACT")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_CONTACT_NOTBLANK")]
        public string Contact { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_DAILYWAGE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_DAILYWAGE_NOTBLANK")]
        public string DailyWage { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "DAILYWAGE_FREQUENCY")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "DAILYWAGE_FREQUENCY_NOTBLANK")]
        public string DailyWageFrequency { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_HOURLYRATE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_HOURLYRATE_NOTBLANK")]
        public string OTHourlyRate { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_SKILLSET")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_SKILLSET_NOTBLANK")]
        public string SkillSet { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_STDWORKINGHR")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_STDWORKINGHR_NOTBLANK")]
        public string StandardWorkingHr { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_SHIFT")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_SHIFT_NOTBLANK")]
        public string Shift { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "LABOUR_ROLE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "LABOUR_ROLE_NOTBLANK")]
        public string Role { get; set; }

    }
}
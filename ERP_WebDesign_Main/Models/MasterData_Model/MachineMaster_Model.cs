using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Models.MasterData_Model
{
    public class MachineMaster_Model : Base_Model
    {
        [Key]
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_ID")]
        public string MachineID { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_Name")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_NAME_NOTBLANK")]
        public string MachineName { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_DESC")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_DESC_NOTBLANK")]
        [DataType(DataType.MultilineText)]
        public string MachineDesc { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "INSTALL_DATE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "INSTALL_DATE_NOTBLANK")]
        public DateTime InstallDate { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_LIFE")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_LIFE_NOTBLANK")]
        public string MCLife { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_WARRANTYPERIOD")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_WARRANTYPERIOD_NOTBLANK")]
        public string WarrantyPeriod { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_OILREQUIRED")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_OILREQUIRED_NOTBLANK")]
        public string OilRequired { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_POWERREQUIRED")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_POWERREQUIRED_NOTBLANK")]
        public string PowerRequired { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_STANDARDOUTPUTQTY")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_STANDARDOUTPUTQTY_NOTBLANK")]
        public string StandardOutputQTY { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_STANDARDOUTPUTUNIT")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_STANDARDOUTPUTUNIT_NOTBLANK")]
        public string StandardOutputUnit { get; set; }
        [Display(ResourceType = typeof(ERP_WebDesign_MasterModelResource), Name = "MACHINE_STANDARDRUNNINGTIME")]
        [Required(ErrorMessageResourceType = typeof(ERP_WebDesign_MasterModelResource), ErrorMessageResourceName = "MACHINE_STANDARDRUNNINGTIME_NOTBLANK")]
        public string StandardRunningTime { get; set; }



    }
}
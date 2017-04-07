//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_WebDesign_Main.Model_Entity_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Items()
        {
            this.tbl_Specification = new HashSet<tbl_Specification>();
            this.tbl_Codification = new HashSet<tbl_Codification>();
        }
    
        public string ItemID { get; set; }
        public string ItemCode { get; set; }
        public string ItemDisplayName { get; set; }
        public string GroupID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    
        public virtual tbl_Groups tbl_Groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Specification> tbl_Specification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Codification> tbl_Codification { get; set; }
    }
}

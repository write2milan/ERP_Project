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
    
    public partial class tbl_Groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Groups()
        {
            this.tbl_Items = new HashSet<tbl_Items>();
        }
    
        public string GroupID { get; set; }
        public string GroupCode { get; set; }
        public string GroupDisplayName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Items> tbl_Items { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERP_DEMOEntities : DbContext
    {
        public ERP_DEMOEntities()
            : base("name=ERP_DEMOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_User> tbl_User { get; set; }
        public virtual DbSet<tbl_ExceptionLogger> tbl_ExceptionLogger { get; set; }
        public virtual DbSet<tbl_ProcessMaster> tbl_ProcessMaster { get; set; }
        public virtual DbSet<tbl_ProductionUnitMaster> tbl_ProductionUnitMaster { get; set; }
        public virtual DbSet<tbl_ProductMaster> tbl_ProductMaster { get; set; }
        public virtual DbSet<tbl_SalesOrder> tbl_SalesOrder { get; set; }
        public virtual DbSet<tbl_ShiftMaster> tbl_ShiftMaster { get; set; }
        public virtual DbSet<tbl_Groups> tbl_Groups { get; set; }
        public virtual DbSet<tbl_Items> tbl_Items { get; set; }
        public virtual DbSet<tbl_Rack> tbl_Rack { get; set; }
        public virtual DbSet<tbl_Specification> tbl_Specification { get; set; }
        public virtual DbSet<tbl_Codification> tbl_Codification { get; set; }

        public System.Data.Entity.DbSet<ERP_WebDesign_Main.Models.MasterData_Model.ProcessMaster_Model> ProcessMaster_Model { get; set; }
    }
}

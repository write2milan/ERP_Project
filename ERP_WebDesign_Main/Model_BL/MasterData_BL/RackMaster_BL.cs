using ERP_WebDesign_Main.Model_Entity_DB;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class RackMaster_BL : Base_BL<RackMaster_Model>
    {
        public override IEnumerable<RackMaster_Model> GetAllItems()
        {
            IEnumerable<RackMaster_Model> objEntityMasterCollection = null;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMasterCollection = (from each in objContext.tbl_Rack
                                                 select new RackMaster_Model
                                                 {
                                                     RackID = each.RackID,
                                                     RackCode = each.RackCode,
                                                     RackDisplayName = each.RackDisplayName,
                                                     CreatedBy = each.CreatedBy,
                                                     CreatedDateTime = each.CreatedDateTime,
                                                     ModifiedBy = each.ModifiedBy,
                                                     ModifiedDateTime = each.ModifiedDateTime
                                                 }).ToList<RackMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objEntityMasterCollection;
        }
        public override object InsertData(RackMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    int rowCount = objContext.tbl_Rack.Count();
                    objContext.tbl_Rack.Add(new tbl_Rack
                    {
                        RackID = ERP_WebDesign_MasterModelResource.RACK_ID_PREFIX + rowCount,
                        RackCode = entity.RackCode,
                        RackDisplayName = entity.RackDisplayName,
                        CreatedBy = CommonHelper.CommonHelper.CurrentUserLoginName(),
                        ModifiedBy = CommonHelper.CommonHelper.CurrentUserLoginName(),
                        CreatedDateTime = DateTime.Now,
                        ModifiedDateTime = DateTime.Now

                    });
                    objContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public override RackMaster_Model DetailsData(string ItemId)
        {
            RackMaster_Model objEntityMaster = new RackMaster_Model();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMaster = (from each in objContext.tbl_Rack
                                       where each.RackID == ItemId
                                       select new RackMaster_Model
                                       {
                                           RackID = each.RackID,
                                           RackDisplayName = each.RackDisplayName,
                                           RackCode = each.RackCode,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).FirstOrDefault<RackMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objEntityMaster;
        }
        public override object UpdateData(string ItemId, RackMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_Rack updateEntity = objContext.tbl_Rack.Where(p => p.RackID == ItemId).FirstOrDefault<tbl_Rack>();
                    updateEntity.RackCode = entity.RackCode;
                    updateEntity.RackDisplayName = entity.RackDisplayName;
                    updateEntity.ModifiedBy = CommonHelper.CommonHelper.CurrentUserLoginName();
                    updateEntity.ModifiedDateTime = DateTime.Now;
                    objContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return string.Empty;
        }
        public override object DeleteData(string ItemId)
        {
            throw new NotImplementedException();
        }
        public object ExistCode(string code)
        {
            bool isExistCode = false;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    isExistCode = objContext.tbl_Rack.Any(each => each.RackCode.Equals(code, StringComparison.CurrentCultureIgnoreCase));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new { IsExist = isExistCode, AlertMessage = ERP_WebDesign_MasterModelResource.CODE_EXIST_ALERTMESSAGE };
        }
    }
}
using ERP_WebDesign_Main.Model_Entity_DB;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class GroupsMaster_BL : Base_BL<GroupsMaster_Model>
    {
        public override IEnumerable<GroupsMaster_Model> GetAllItems()
        {
            IEnumerable<GroupsMaster_Model> objEntityMasterCollection = null;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMasterCollection = (from each in objContext.tbl_Groups
                                                 select new GroupsMaster_Model
                                                 {
                                                     GroupID = each.GroupID,
                                                     GroupCode = each.GroupCode,
                                                     GroupDisplayName = each.GroupDisplayName,
                                                     CreatedBy = each.CreatedBy,
                                                     CreatedDateTime = each.CreatedDateTime,
                                                     ModifiedBy = each.ModifiedBy,
                                                     ModifiedDateTime = each.ModifiedDateTime
                                                 }).ToList<GroupsMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objEntityMasterCollection;
        }
        public override object InsertData(GroupsMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    int rowCount = objContext.tbl_Groups.Count();
                    objContext.tbl_Groups.Add(new tbl_Groups
                    {
                        GroupID = ERP_WebDesign_MasterModelResource.GROUP_ID_PREFIX + rowCount,
                        GroupCode = entity.GroupCode,
                        GroupDisplayName = entity.GroupDisplayName,
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
        public override object UpdateData(string ItemId, GroupsMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_Groups updateEntity = objContext.tbl_Groups.Where(p => p.GroupID == ItemId).FirstOrDefault<tbl_Groups>();
                    updateEntity.GroupCode = entity.GroupCode;
                    updateEntity.GroupDisplayName = entity.GroupDisplayName;
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
        public override GroupsMaster_Model DetailsData(string ItemId)
        {
            GroupsMaster_Model objEntityMaster = new GroupsMaster_Model();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMaster = (from each in objContext.tbl_Groups
                                       where each.GroupID == ItemId
                                       select new GroupsMaster_Model
                                       {
                                           GroupID = each.GroupID,
                                           GroupDisplayName = each.GroupDisplayName,
                                           GroupCode = each.GroupCode,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).FirstOrDefault<GroupsMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objEntityMaster;
        }
        public object ExistCode(string code)
        {
            bool isExistCode = false;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    isExistCode = objContext.tbl_Groups.Any(each => each.GroupCode.Equals(code, StringComparison.CurrentCultureIgnoreCase));
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
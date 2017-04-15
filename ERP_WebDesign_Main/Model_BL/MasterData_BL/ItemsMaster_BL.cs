using ERP_WebDesign_Main.Model_Entity_DB;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class ItemsMaster_BL : Base_BL<ItemsMaster_Model>
    {
        public override object DeleteData(string ItemId)
        {
            throw new NotImplementedException();
        }

        public override ItemsMaster_Model DetailsData(string ItemId)
        {
            ItemsMaster_Model objEntityMaster = new ItemsMaster_Model();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMaster = (from each in objContext.tbl_Items
                                       where each.ItemID == ItemId
                                       select new ItemsMaster_Model
                                       {
                                           GroupID = each.GroupID,
                                           ItemID = each.ItemID,
                                           ItemCode = each.ItemCode,
                                           ItemDisplayName = each.ItemDisplayName,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).FirstOrDefault<ItemsMaster_Model>();

                    objEntityMaster.Groups = PopulateGroupsDropdown();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objEntityMaster;
        }

        public override IEnumerable<ItemsMaster_Model> GetAllItems()
        {
            IEnumerable<ItemsMaster_Model> objEntityMasterCollection = null;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMasterCollection = (from each in objContext.tbl_Items
                                                 select new ItemsMaster_Model
                                                 {
                                                     GroupID = each.GroupID,
                                                     ItemCode = each.ItemCode,
                                                     ItemDisplayName = each.ItemDisplayName,
                                                     ItemID = each.ItemID,
                                                     CreatedBy = each.CreatedBy,
                                                     CreatedDateTime = each.CreatedDateTime,
                                                     ModifiedBy = each.ModifiedBy,
                                                     ModifiedDateTime = each.ModifiedDateTime
                                                 }).ToList<ItemsMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objEntityMasterCollection;
        }

        public override object InsertData(ItemsMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    int rowCount = objContext.tbl_Items.Count();
                    objContext.tbl_Items.Add(new tbl_Items
                    {
                        ItemID = ERP_WebDesign_MasterModelResource.ITEMS_ID_PREFIX + rowCount,
                        ItemCode = entity.ItemCode,
                        ItemDisplayName = entity.ItemDisplayName,
                        GroupID = entity.GroupID,
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

        public override object UpdateData(string ItemId, ItemsMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_Items updateEntity = objContext.tbl_Items.Where(p => p.ItemID == ItemId).FirstOrDefault<tbl_Items>();
                    updateEntity.ItemDisplayName = entity.ItemDisplayName;
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

        public object ExistCode(string code)
        {
            bool isExistCode = false;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    isExistCode = objContext.tbl_Items.Any(each => each.ItemCode.Equals(code, StringComparison.CurrentCultureIgnoreCase));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new { IsExist = isExistCode, AlertMessage = ERP_WebDesign_MasterModelResource.CODE_EXIST_ALERTMESSAGE };
        }

        private List<SelectListItem> PopulateGroupsDropdown()
        {
            List<SelectListItem> objGrps = new List<SelectListItem>();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objGrps = (from each in objContext.tbl_Groups
                               select new SelectListItem
                               {
                                   Text = each.GroupDisplayName,
                                   Value = each.GroupID
                               })
                               .ToList<SelectListItem>();
                    objGrps.Add(new SelectListItem { Text = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objGrps;
        }

        public ItemsMaster_Model BindModelForInsertion()
        {
            ItemsMaster_Model objEntityModel = new ItemsMaster_Model();
            try
            {
                objEntityModel.Groups = PopulateGroupsDropdown();
                objEntityModel.GroupID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
            }
            catch (Exception)
            {
                throw;
            }
            return objEntityModel;
        }
    }
}
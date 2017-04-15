using ERP_WebDesign_Main.Model_Entity_DB;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class SpecificationMaster_BL : Base_BL<SpecificationMaster_Model>
    {
        public override object DeleteData(string ItemId)
        {
            throw new NotImplementedException();
        }

        public override SpecificationMaster_Model DetailsData(string ItemId)
        {
            SpecificationMaster_Model objEntityMaster = new SpecificationMaster_Model();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMaster = (from each in objContext.tbl_Specification
                                       where each.SpecificationID == ItemId
                                       select new SpecificationMaster_Model
                                       {
                                           SpecificationID = each.SpecificationID,
                                           SpecificationDisplayName = each.SpecificationDisplayName,
                                           SpecificationCode = each.SpecificationCode,
                                           GroupID = each.GroupID,
                                           ItemID = each.ItemID,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).FirstOrDefault<SpecificationMaster_Model>();
                    objEntityMaster.Groups = PopulateGroupsDropdown();
                    objEntityMaster.Items = PopulateItemsDropdown(objEntityMaster.GroupID);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objEntityMaster;
        }

        public override IEnumerable<SpecificationMaster_Model> GetAllItems()
        {
            IEnumerable<SpecificationMaster_Model> objEntityMasterCollection = null;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objEntityMasterCollection = (from each in objContext.tbl_Specification
                                                 select new SpecificationMaster_Model
                                                 {
                                                     SpecificationID = each.SpecificationID,
                                                     SpecificationCode = each.SpecificationCode,
                                                     SpecificationDisplayName = each.SpecificationDisplayName,
                                                     CreatedBy = each.CreatedBy,
                                                     CreatedDateTime = each.CreatedDateTime,
                                                     ModifiedBy = each.ModifiedBy,
                                                     ModifiedDateTime = each.ModifiedDateTime
                                                 }).ToList<SpecificationMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objEntityMasterCollection;
        }

        public override object InsertData(SpecificationMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    int rowCount = objContext.tbl_Specification.Count();
                    objContext.tbl_Specification.Add(new tbl_Specification
                    {
                        SpecificationID = ERP_WebDesign_MasterModelResource.SPEC_ID_PREFIX + rowCount,
                        SpecificationCode = entity.SpecificationCode,
                        SpecificationDisplayName = entity.SpecificationDisplayName,
                        GroupID = entity.GroupID,
                        ItemID = entity.ItemID,
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

        public override object UpdateData(string ItemId, SpecificationMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_Specification updateEntity = objContext.tbl_Specification.Where(p => p.SpecificationID == ItemId).FirstOrDefault<tbl_Specification>();
                    updateEntity.SpecificationDisplayName = entity.SpecificationDisplayName;
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
        public List<SelectListItem> PopulateItemsDropdown(string grpId)
        {
            List<SelectListItem> objItems = new List<SelectListItem>();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objItems = (from each in objContext.tbl_Items
                                where each.GroupID.Equals(grpId, StringComparison.CurrentCultureIgnoreCase)
                                select new SelectListItem
                                {
                                    Text = each.ItemDisplayName,
                                    Value = each.ItemID
                                })
                               .ToList<SelectListItem>();
                    objItems.Add(new SelectListItem { Text = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objItems;
        }

        public SpecificationMaster_Model BindModelForInsertion()
        {
            SpecificationMaster_Model objEntityModel = new SpecificationMaster_Model();
            try
            {
                objEntityModel.Groups = PopulateGroupsDropdown();
                objEntityModel.GroupID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
                objEntityModel.ItemID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
            }
            catch (Exception)
            {
                throw;
            }
            return objEntityModel;
        }

        public object ExistCode(string code)
        {
            bool isExistCode = false;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    isExistCode = objContext.tbl_Specification.Any(each => each.SpecificationCode.Equals(code, StringComparison.CurrentCultureIgnoreCase));
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
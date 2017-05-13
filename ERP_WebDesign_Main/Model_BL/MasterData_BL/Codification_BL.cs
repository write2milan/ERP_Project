using ERP_WebDesign_Main.Model_Entity_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System.Text;
using System.Data.Entity.Core.Objects;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class Codification_BL : Base_BL<Models.MasterData_Model.Codification_Model>
    {

        private string CreateStoreProcXmlInput(string searchText = "", int pageNo = 1, int pageSize = 10)
        {
            StringBuilder spInput = new StringBuilder();
            spInput.Append("<ROOT>");
            spInput.Append("<CODIFICATIONCODE><![CDATA[" + searchText + "]]></CODIFICATIONCODE>");
            spInput.Append("<PAGENO>" + pageNo + "</PAGENO>");
            spInput.Append("<PAGESIZE>" + pageSize + "</PAGESIZE>");
            spInput.Append("</ROOT>");
            return spInput.ToString();
        }
        public Codification GetAllItems(string searchText = "", int pageNo = 1, int pageSize = 10)
        {
            Codification objEntity = new Codification();
            List<Codification_Model> objCollection = new List<Codification_Model>();

            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    ObjectParameter outPut = new ObjectParameter("TOTALRECORDCOUNT", typeof(Int32));
                    objCollection = (from each in objContext.ERP_DB_SPGetCodificationSearchData(CreateStoreProcXmlInput(searchText, pageNo, pageSize), outPut).ToList<ERP_DB_SPGetCodificationSearchData_Result>()
                                     select new Codification_Model
                                     {
                                         CodificationID = each.CodificationID,
                                         CodificationCode = each.CodificationCode,
                                         CreatedBy = each.CreatedBy,
                                         CreatedDateTime = each.CreatedDateTime,
                                         ModifiedBy = each.ModifiedBy,
                                         ModifiedDateTime = each.ModifiedDateTime
                                     }).ToList<Codification_Model>();
                    objEntity.Collection = objCollection;
                    objEntity.ItemCount = int.Parse(Convert.ToString(outPut.Value));
                    objEntity.PageNo = pageNo;
                    objEntity.PageSize = pageSize;

                }
            }
            catch (Exception)
            {
                throw;
            }
            return objEntity;
        }
        public override IEnumerable<Codification_Model> GetAllItems()
        {
            IEnumerable<Codification_Model> objCodiMasterCollection = null;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objCodiMasterCollection = (from each in objContext.tbl_Codification
                                               select new Codification_Model
                                               {
                                                   CodificationID = each.CodificationID,
                                                   CodificationCode = each.CodificationCode,
                                                   CreatedBy = each.CreatedBy,
                                                   CreatedDateTime = each.CreatedDateTime,
                                                   ModifiedBy = each.ModifiedBy,
                                                   ModifiedDateTime = each.ModifiedDateTime
                                               }).ToList<Codification_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objCodiMasterCollection;
        }
        public override object InsertData(Codification_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    int rowCount = objContext.tbl_Codification.Count();
                    objContext.tbl_Codification.Add(new tbl_Codification
                    {
                        CodificationID = ERP_WebDesign_MasterModelResource.CODIFICATION_ID_PREFIX + rowCount,
                        CodificationCode = entity.CodificationCode,
                        GroupID = entity.GroupID,
                        ItemID = entity.ItemID,
                        RackID = entity.RackID,
                        SpecificationID = entity.SpecificationID,
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
        public override object DeleteData(string ItemId)
        {
            throw new NotImplementedException();
        }
        public override Codification_Model DetailsData(string ItemId)
        {
            Codification_Model objCodiMaster = new Codification_Model();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objCodiMaster = (from each in objContext.tbl_Codification
                                     where each.CodificationID == ItemId
                                     select new Codification_Model
                                     {
                                         CodificationCode = each.CodificationCode,
                                         CodificationID = each.CodificationID,
                                         GroupID = each.GroupID,
                                         ItemID = each.ItemID,
                                         RackID = each.RackID,
                                         SpecificationID = each.SpecificationID,
                                         CreatedBy = each.CreatedBy,
                                         CreatedDateTime = each.CreatedDateTime,
                                         ModifiedBy = each.ModifiedBy,
                                         ModifiedDateTime = each.ModifiedDateTime
                                     }).FirstOrDefault<Codification_Model>();
                    objCodiMaster.Groups = PopulateGroupsDropdown();
                    objCodiMaster.Items = PopulateItemsDropdown(objCodiMaster.GroupID);
                    objCodiMaster.Racks = PopulateRacksDropdown();
                    objCodiMaster.Specifications = PopulateSpecDropdown(objCodiMaster.ItemID);

                }
            }
            catch (Exception)
            {

                throw;
            }
            return objCodiMaster;
        }
        public override object UpdateData(string ItemId, Codification_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_Codification updateEntity = objContext.tbl_Codification.Where(p => p.CodificationID == ItemId).FirstOrDefault<tbl_Codification>();
                    updateEntity.CodificationCode = entity.CodificationCode;
                    updateEntity.GroupID = entity.GroupID;
                    updateEntity.ItemID = entity.ItemID;
                    updateEntity.RackID = entity.RackID;
                    updateEntity.SpecificationID = entity.SpecificationID;
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

        public Codification_Model BindModelForInsertion()
        {
            Codification_Model objCodeModel = new Codification_Model();
            try
            {
                objCodeModel.Groups = PopulateGroupsDropdown();
                objCodeModel.Racks = PopulateRacksDropdown();
                objCodeModel.GroupID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
                objCodeModel.ItemID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
                objCodeModel.RackID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
                objCodeModel.SpecificationID = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE;
            }
            catch (Exception)
            {
                throw;
            }
            return objCodeModel;
        }

        private List<Models.MasterData_Model.CodificationSelectListItem> PopulateGroupsDropdown()
        {
            List<Models.MasterData_Model.CodificationSelectListItem> objGrps = new List<Models.MasterData_Model.CodificationSelectListItem>();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objGrps = (from each in objContext.tbl_Groups
                               select new Models.MasterData_Model.CodificationSelectListItem
                               {
                                   DisplayText = each.GroupDisplayName,
                                   Code = each.GroupCode,
                                   Value = each.GroupID
                               })
                               .ToList<Models.MasterData_Model.CodificationSelectListItem>();
                    objGrps.Add(new CodificationSelectListItem { Code = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE, DisplayText = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objGrps;
        }

        public List<Models.MasterData_Model.CodificationSelectListItem> PopulateItemsDropdown(string grpId)
        {
            List<Models.MasterData_Model.CodificationSelectListItem> objItems = new List<Models.MasterData_Model.CodificationSelectListItem>();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objItems = (from each in objContext.tbl_Items
                                where each.GroupID.Equals(grpId, StringComparison.CurrentCultureIgnoreCase)
                                select new Models.MasterData_Model.CodificationSelectListItem
                                {
                                    DisplayText = each.ItemDisplayName,
                                    Code = each.ItemCode,
                                    Value = each.ItemID
                                })
                               .ToList<Models.MasterData_Model.CodificationSelectListItem>();
                    objItems.Add(new CodificationSelectListItem { Code = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE, DisplayText = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objItems;
        }

        public List<Models.MasterData_Model.CodificationSelectListItem> PopulateSpecDropdown(string itemId)
        {
            List<Models.MasterData_Model.CodificationSelectListItem> objSpec = new List<Models.MasterData_Model.CodificationSelectListItem>();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objSpec = (from each in objContext.tbl_Specification
                               where each.ItemID.Equals(itemId, StringComparison.CurrentCultureIgnoreCase)
                               select new Models.MasterData_Model.CodificationSelectListItem
                               {
                                   DisplayText = each.SpecificationDisplayName,
                                   Code = each.SpecificationCode,
                                   Value = each.SpecificationID
                               })
                               .ToList<Models.MasterData_Model.CodificationSelectListItem>();
                    objSpec.Add(new CodificationSelectListItem { Code = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE, DisplayText = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objSpec;
        }

        private List<Models.MasterData_Model.CodificationSelectListItem> PopulateRacksDropdown()
        {
            List<Models.MasterData_Model.CodificationSelectListItem> objRacks = new List<Models.MasterData_Model.CodificationSelectListItem>();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objRacks = (from each in objContext.tbl_Rack
                                select new Models.MasterData_Model.CodificationSelectListItem
                                {
                                    DisplayText = each.RackDisplayName,
                                    Code = each.RackCode,
                                    Value = each.RackID
                                })
                               .ToList<Models.MasterData_Model.CodificationSelectListItem>();
                    objRacks.Add(new CodificationSelectListItem { Code = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE, DisplayText = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objRacks;
        }

        public object ExistCode(string code, string itemid = "")
        {
            bool isExistCode = false;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    if (!string.IsNullOrEmpty(itemid))
                        isExistCode = objContext.tbl_Codification.Where(filter => filter.CodificationID != itemid).Any(each => each.CodificationCode.Equals(code, StringComparison.CurrentCultureIgnoreCase));
                    else
                        isExistCode = objContext.tbl_Codification.Any(each => each.CodificationCode.Equals(code, StringComparison.CurrentCultureIgnoreCase));
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
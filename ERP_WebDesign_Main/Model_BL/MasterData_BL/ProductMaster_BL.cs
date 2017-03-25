using ERP_WebDesign_Main.Model_Entity_DB;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class ProductMaster_BL : Base_BL<ProductMaster_Model>
    {
        public override IEnumerable<ProductMaster_Model> GetAllItems()
        {
            IEnumerable<ProductMaster_Model> objProdMasterCollection = null;
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objProdMasterCollection = (from each in objContext.tbl_ProductMaster
                                               select new ProductMaster_Model
                                               {
                                                   ProductID = each.ProductID,
                                                   ProductDesc = each.ProductDesc,
                                                   ProductName = each.ProductName,
                                                   CreatedBy = each.CreatedBy,
                                                   CreatedDateTime = each.CreatedDateTime,
                                                   ModifiedBy = each.ModifiedBy,
                                                   ModifiedDateTime = each.ModifiedDateTime
                                               }).ToList<ProductMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objProdMasterCollection;

        }
        public override void InsertData(ProductMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    int rowCount = objContext.tbl_ProductMaster.Count();
                    objContext.tbl_ProductMaster.Add(new tbl_ProductMaster
                    {
                        ProductID = ERP_WebDesign_MasterModelResource.PRODUCT_ID_PREFIX + rowCount,
                        ProductName = entity.ProductName,
                        ProductDesc = entity.ProductDesc,
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
        }
        public override void UpdateData(string ItemId, ProductMaster_Model entity)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_ProductMaster updateEntity = objContext.tbl_ProductMaster.Where(p => p.ProductID == ItemId).FirstOrDefault<tbl_ProductMaster>();
                    updateEntity.ProductName = entity.ProductName;
                    updateEntity.ProductDesc = entity.ProductDesc;
                    updateEntity.ModifiedBy = CommonHelper.CommonHelper.CurrentUserLoginName();
                    updateEntity.ModifiedDateTime = DateTime.Now;
                    objContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public override void DeleteData(string ItemId)
        {
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {

                    tbl_ProductMaster deleteEntity = objContext.tbl_ProductMaster.Where(p => p.ProductID == ItemId).FirstOrDefault<tbl_ProductMaster>();
                    objContext.tbl_ProductMaster.Remove(deleteEntity);
                    objContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public override ProductMaster_Model DetailsData(string ItemId)
        {
            ProductMaster_Model objProdMaster = new ProductMaster_Model();
            try
            {
                using (ERP_DEMOEntities objContext = new ERP_DEMOEntities())
                {
                    objProdMaster = (from each in objContext.tbl_ProductMaster
                                     where each.ProductID == ItemId
                                     select new ProductMaster_Model
                                     {
                                         ProductID = each.ProductID,
                                         ProductDesc = each.ProductDesc,
                                         ProductName = each.ProductName,
                                         CreatedBy = each.CreatedBy,
                                         CreatedDateTime = each.CreatedDateTime,
                                         ModifiedBy = each.ModifiedBy,
                                         ModifiedDateTime = each.ModifiedDateTime
                                     }).FirstOrDefault<ProductMaster_Model>();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objProdMaster;
        }
    }
}
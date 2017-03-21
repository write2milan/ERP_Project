using ERP_WebDesign_Main.Model_Entity_DB;
using ERP_WebDesign_Main.Models.MasterData_Model;
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
                                                   ProductDesc = each.ProductDesc
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
                    objContext.tbl_ProductMaster.Add(new tbl_ProductMaster
                    {
                        ProductID = entity.ProductID,
                        ProductDesc = entity.ProductDesc
                    });
                    objContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
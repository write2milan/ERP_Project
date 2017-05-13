using ERP_WebDesign_Main.Model_DAL;
using ERP_WebDesign_Main.Models.MasterData_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class ProductionUnitMaster_BL
    {
        public IEnumerable<ProductionUnitMaster_Model> GetAllItems(object[] parameters)
        {
            IEnumerable<ProductionUnitMaster_Model> objProductionUnitMasterCollection = null;
            try
            {
                ERPDataService<ProductionUnitMaster_Model> erpServ = new ERPDataService<ProductionUnitMaster_Model>();
                string spQuery = "[Get_AllProductionUnits]";
                objProductionUnitMasterCollection = (from each in erpServ.GetAll(spQuery, parameters)
                                              select new ProductionUnitMaster_Model
                                              {
                                                  Site = each.Site,
                                                  Location = each.Location,
                                                  Address = each.Address,                                                 
                                                  CreatedBy = each.CreatedBy,
                                                  CreatedDateTime = each.CreatedDateTime,
                                                  ModifiedBy = each.ModifiedBy,
                                                  ModifiedDateTime = each.ModifiedDateTime
                                              }).ToList<ProductionUnitMaster_Model>();


            }
            catch (Exception)
            {

                throw;
            }

            return objProductionUnitMasterCollection;


        }
        public object InsertData(ProductionUnitMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Create_ProductionUnit] {0}, {1}, {2}, {3}, {4}, {5}, {6}";
                object[] parameters = {
                                        entity.Site,
                                        entity.Location,
                                        entity.Address,
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                        DateTime.Now,
                                       };
                ERPDataService<ProductionUnitMaster_Model> erpServ = new ERPDataService<ProductionUnitMaster_Model>();
                result = erpServ.Insert(spQuery, parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public object UpdateData(ProductionUnitMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Update_ProductionUnit] {0}, {1}, {2}, {3}, {4}";
                object[] parameters = {
                                        entity.Site,
                                        entity.Location,
                                        entity.Address,                                        
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                       };
                ERPDataService<ProductionUnitMaster_Model> erpServ = new ERPDataService<ProductionUnitMaster_Model>();
                result = erpServ.Update(spQuery, parameters);
            }
            catch (Exception)
            {
                throw;
            }
            return string.Empty;

        }
        public object DeleteData(string ItemId)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return string.Empty;
        }
        public ProductionUnitMaster_Model DetailsData(string ItemId)
        {
            ProductionUnitMaster_Model objProductionUnitMaster = new ProductionUnitMaster_Model();
            try
            {
                string spQuery = "[Get_ProductionUnitByID] {0}";
                object[] parameters = { ItemId };
                ERPDataService<ProductionUnitMaster_Model> erpServ = new ERPDataService<ProductionUnitMaster_Model>();
                //objProcessMaster=erpServ.GetbyID(spQuery, parameters);

                objProductionUnitMaster = (from each in erpServ.GetAll(spQuery, parameters)
                                    select new ProductionUnitMaster_Model
                                    {
                                        Site = each.Site,
                                        Location = each.Location,
                                        Address = each.Address,                                       
                                        CreatedBy = each.CreatedBy,
                                        CreatedDateTime = each.CreatedDateTime,
                                        ModifiedBy = each.ModifiedBy,
                                        ModifiedDateTime = each.ModifiedDateTime
                                    }).FirstOrDefault<ProductionUnitMaster_Model>();
                
            }
            catch (Exception)
            {

                throw;
            }
            return objProductionUnitMaster;
        }
    }
}
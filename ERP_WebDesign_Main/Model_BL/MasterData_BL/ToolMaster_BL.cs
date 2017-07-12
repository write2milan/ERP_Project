using ERP_WebDesign_Main.Model_DAL;
using ERP_WebDesign_Main.Models.MasterData_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class ToolMaster_BL
    {
        public IEnumerable<ToolMaster_Model> GetAllItems(object[] parameters)
        {
            IEnumerable<ToolMaster_Model> objMasterCollection = null;
            try
            {
                ERPDataService<ToolMaster_Model> erpServ = new ERPDataService<ToolMaster_Model>();
                string spQuery = "[Get_AllTools]";
                objMasterCollection = (from each in erpServ.GetAll(spQuery, parameters)
                                       select new ToolMaster_Model
                                       {
                                           ToolID = each.ToolID,
                                           ToolName = each.ToolName,
                                           ToolDesc = each.ToolDesc,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).ToList<ToolMaster_Model>();


            }
            catch (Exception)
            {

                throw;
            }

            return objMasterCollection;


        }
        public object InsertData(ToolMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Create_Tool] {0}, {1}, {2}, {3}, {4}, {5}";
                object[] parameters = {
                                        entity.ToolName,
                                        entity.ToolDesc,                                       
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                        DateTime.Now,
                                       };
                ERPDataService<ToolMaster_Model> erpServ = new ERPDataService<ToolMaster_Model>();
                result = erpServ.Insert(spQuery, parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public object UpdateData(ToolMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Update_Tool] {0}, {1}, {2}, {3}, {4}";
                object[] parameters = {
                                        entity.ToolID,
                                        entity.ToolName,
                                        entity.ToolDesc,
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                       };
                ERPDataService<ToolMaster_Model> erpServ = new ERPDataService<ToolMaster_Model>();
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
        public ToolMaster_Model DetailsData(string ItemId)
        {
            ToolMaster_Model objMaster = new ToolMaster_Model();
            try
            {
                string spQuery = "[Get_ToolByID] {0}";
                object[] parameters = { ItemId };
                ERPDataService<ToolMaster_Model> erpServ = new ERPDataService<ToolMaster_Model>();

                objMaster = (from each in erpServ.GetAll(spQuery, parameters)
                             select new ToolMaster_Model
                             {
                                 ToolID = each.ToolID,
                                 ToolName = each.ToolName,
                                 ToolDesc = each.ToolDesc,
                                 CreatedBy = each.CreatedBy,
                                 CreatedDateTime = each.CreatedDateTime,
                                 ModifiedBy = each.ModifiedBy,
                                 ModifiedDateTime = each.ModifiedDateTime
                             }).FirstOrDefault<ToolMaster_Model>();

            }
            catch (Exception)
            {

                throw;
            }
            return objMaster;
        }
    }
}
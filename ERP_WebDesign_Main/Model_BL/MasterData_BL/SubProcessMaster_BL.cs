using ERP_WebDesign_Main.Model_DAL;
using ERP_WebDesign_Main.Models.MasterData_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class SubProcessMaster_BL
    {
        public IEnumerable<SubProcessMaster_Model> GetAllItems(object[] parameters)
        {
            IEnumerable<SubProcessMaster_Model> objMasterCollection = null;
            try
            {
                ERPDataService<SubProcessMaster_Model> erpServ = new ERPDataService<SubProcessMaster_Model>();
                string spQuery = "[Get_AllSubProcess]";
                objMasterCollection = (from each in erpServ.GetAll(spQuery, parameters)
                                                     select new SubProcessMaster_Model
                                                     {
                                                         SubProcessID  = each.SubProcessID,
                                                         SubProcessName = each.SubProcessName,
                                                         SubProcessDesc = each.SubProcessDesc,
                                                         CreatedBy = each.CreatedBy,
                                                         CreatedDateTime = each.CreatedDateTime,
                                                         ModifiedBy = each.ModifiedBy,
                                                         ModifiedDateTime = each.ModifiedDateTime
                                                     }).ToList<SubProcessMaster_Model>();


            }
            catch (Exception)
            {

                throw;
            }

            return objMasterCollection;


        }
        public object InsertData(SubProcessMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Create_SubProcess] {0}, {1}, {2}, {3}, {4}, {5}";
                object[] parameters = {
                                        entity.SubProcessName,
                                        entity.SubProcessDesc,                                       
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                        DateTime.Now,
                                       };
                ERPDataService<SubProcessMaster_Model> erpServ = new ERPDataService<SubProcessMaster_Model>();
                result = erpServ.Insert(spQuery, parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public object UpdateData(SubProcessMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Update_SubProcess] {0}, {1}, {2}, {3}, {4}";
                object[] parameters = {
                                        entity.SubProcessID,
                                        entity.SubProcessName,
                                        entity.SubProcessDesc,
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                       };
                ERPDataService<SubProcessMaster_Model> erpServ = new ERPDataService<SubProcessMaster_Model>();
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
        public SubProcessMaster_Model DetailsData(string ItemId)
        {
            SubProcessMaster_Model objMaster = new SubProcessMaster_Model();
            try
            {
                string spQuery = "[Get_SubProcessByID] {0}";
                object[] parameters = { ItemId };
                ERPDataService<SubProcessMaster_Model> erpServ = new ERPDataService<SubProcessMaster_Model>();

                objMaster = (from each in erpServ.GetAll(spQuery, parameters)
                                           select new SubProcessMaster_Model
                                           {
                                               SubProcessID=each.SubProcessID,
                                               SubProcessName = each.SubProcessName,
                                               SubProcessDesc = each.SubProcessDesc,                                               
                                               CreatedBy = each.CreatedBy,
                                               CreatedDateTime = each.CreatedDateTime,
                                               ModifiedBy = each.ModifiedBy,
                                               ModifiedDateTime = each.ModifiedDateTime
                                           }).FirstOrDefault<SubProcessMaster_Model>();

            }
            catch (Exception)
            {

                throw;
            }
            return objMaster;
        }
    }
}
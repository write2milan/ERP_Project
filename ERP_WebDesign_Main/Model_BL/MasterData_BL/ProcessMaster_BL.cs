using ERP_WebDesign_Main.Model_DAL;
using ERP_WebDesign_Main.Models.MasterData_Model;
using ERP_WebDesign_Main.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class ProcessMaster_BL
    {
        public IEnumerable<ProcessMaster_Model> GetAllItems(object[] parameters)
        {
            IEnumerable<ProcessMaster_Model> objProcessMasterCollection = null;
            try
            {
                ERPDataService<ProcessMaster_Model> erpServ = new ERPDataService<ProcessMaster_Model>();
                string spQuery = "[Get_AllProcesses]";
                objProcessMasterCollection = (from each in erpServ.GetAll(spQuery, parameters)
                                              select new ProcessMaster_Model 
                                           {
                                               ProcessID = each.ProcessID,
                                               ProcessName = each.ProcessName,
                                               ProcessDesc = each.ProcessDesc,
                                               Site=each.Site,
                                               CreatedBy = each.CreatedBy,
                                               CreatedDateTime = each.CreatedDateTime,
                                               ModifiedBy = each.ModifiedBy,
                                               ModifiedDateTime = each.ModifiedDateTime
                                           }).ToList<ProcessMaster_Model>();

               
            }
            catch (Exception)
            {

                throw;
            }

            return objProcessMasterCollection;


        }
        public ProcessMaster_Model BindModelForInsertion()
        {
            ProcessMaster_Model objProcessModel = new ProcessMaster_Model();
            try
            {
                objProcessModel.Sites = PopulateSiteDropdown();                
            }
            catch (Exception)
            {
                throw;
            }
            return objProcessModel;
        }
        private List<SelectListItem> PopulateSiteDropdown()
        {
            List<SelectListItem> objSites = new List<SelectListItem>();
            
            try
            {
                using (ERPDataService<ProcessMaster_Model> erpServ = new ERPDataService<ProcessMaster_Model>())
                {
                    string spQuery = "[Get_AllSites]";
                    object[] parameters = { };
                    objSites = (from each in erpServ.GetAll(spQuery, parameters)
                                select new SelectListItem
                                {
                                    Text = each.Site,
                                    Value = each.Site
                                }
                              ).ToList<SelectListItem>();
                    objSites.Add(new SelectListItem { Text = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_TEXT, Value = ERP_WebDesign_CommonResource.DEFAULT_DROPDOWN_VALUE, Selected = true });
                }
               
            }
            catch (Exception)
            {
                throw;
            }
            return objSites;
        }
        public object InsertData(ProcessMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Create_Process] {0}, {1}, {2}, {3}, {4}, {5}, {6}";
                object[] parameters = {
                                        entity.ProcessName,
                                        entity.ProcessDesc,
                                        entity.Site,
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                        DateTime.Now,
                                       };
                ERPDataService<ProcessMaster_Model> erpServ = new ERPDataService<ProcessMaster_Model>();
                result=erpServ.Insert(spQuery, parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public object UpdateData( ProcessMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Update_Process] {0}, {1}, {2}, {3}, {4}, {5}";
                object[] parameters = {
                                        entity.ProcessID,
                                        entity.ProcessName,
                                        entity.ProcessDesc,
                                        entity.Site,
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                       };
                ERPDataService<ProcessMaster_Model> erpServ = new ERPDataService<ProcessMaster_Model>();
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
        public ProcessMaster_Model DetailsData(string ItemId)
        {
            ProcessMaster_Model objProcessMaster = new ProcessMaster_Model();
            try
            {
                string spQuery = "[Get_ProcessByID] {0}";
                object[] parameters = { ItemId };
                ERPDataService<ProcessMaster_Model> erpServ = new ERPDataService<ProcessMaster_Model>();
                //objProcessMaster=erpServ.GetbyID(spQuery, parameters);

                objProcessMaster = (from each in erpServ.GetAll(spQuery, parameters)                                    
                                   select new ProcessMaster_Model
                                   {
                                       ProcessID = each.ProcessID,
                                       ProcessName = each.ProcessName,
                                       ProcessDesc = each.ProcessDesc,
                                       Site = each.Site,
                                       CreatedBy = each.CreatedBy,
                                       CreatedDateTime = each.CreatedDateTime,
                                       ModifiedBy = each.ModifiedBy,
                                       ModifiedDateTime = each.ModifiedDateTime
                                   }).FirstOrDefault<ProcessMaster_Model>();
                objProcessMaster.Sites = PopulateSiteDropdown();
            }
            catch (Exception)
            {

                throw;
            }
            return objProcessMaster;
        }
    }
}
using ERP_WebDesign_Main.Model_DAL;
using ERP_WebDesign_Main.Models.MasterData_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class MachineMaster_BL
    {
        public IEnumerable<MachineMaster_Model> GetAllItems(object[] parameters)
        {
            IEnumerable<MachineMaster_Model> objMasterCollection = null;
            try
            {
                ERPDataService<MachineMaster_Model> erpServ = new ERPDataService<MachineMaster_Model>();
                string spQuery = "[Get_AllMachines]";
                objMasterCollection = (from each in erpServ.GetAll(spQuery, parameters)
                                       select new MachineMaster_Model
                                       {
                                           MachineID = each.MachineID ,
                                           MachineName = each.MachineName,
                                           MachineDesc = each.MachineDesc,
                                           InstallDate = each.InstallDate,
                                           MCLife = each.MCLife,
                                           WarrantyPeriod=each.WarrantyPeriod,
                                           OilRequired=each.OilRequired,
                                           PowerRequired=each.PowerRequired,
                                           StandardOutputQTY=each.StandardOutputQTY,
                                           StandardOutputUnit=each.StandardOutputUnit,
                                           StandardRunningTime=each.StandardRunningTime,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).ToList<MachineMaster_Model>();


            }
            catch (Exception)
            {

                throw;
            }

            return objMasterCollection;


        }
        public object InsertData(MachineMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Create_Machine] {0}, {1}, {2}, {3}, {4}, {5},{6}, {7}, {8}, {9}, {10}, {11},{12}, {13}";
                object[] parameters = {
                                            entity.MachineName,
                                            entity.MachineDesc,
                                            entity.InstallDate,
                                            entity.MCLife,
                                            entity.WarrantyPeriod,
                                            entity.OilRequired,
                                            entity.PowerRequired,
                                            entity.StandardOutputQTY,
                                            entity.StandardOutputUnit,
                                            entity.StandardRunningTime,
                                            
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                        DateTime.Now,
                                       };
                ERPDataService<MachineMaster_Model> erpServ = new ERPDataService<MachineMaster_Model>();
                result = erpServ.Insert(spQuery, parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public object UpdateData(MachineMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Update_Machine] {0}, {1}, {2}, {3}, {4}, {5},{6}, {7}, {8}, {9}, {10}, {11},{12}";
                object[] parameters = {
                                            entity.MachineID ,
                                            entity.MachineName,
                                            entity.MachineDesc,
                                            entity.InstallDate,
                                            entity.MCLife,
                                            entity.WarrantyPeriod,
                                            entity.OilRequired,
                                            entity.PowerRequired,
                                            entity.StandardOutputQTY,
                                            entity.StandardOutputUnit,
                                            entity.StandardRunningTime,                                           
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                       };
                ERPDataService<MachineMaster_Model> erpServ = new ERPDataService<MachineMaster_Model>();
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
        public MachineMaster_Model DetailsData(string ItemId)
        {
            MachineMaster_Model objMaster = new MachineMaster_Model();
            try
            {
                string spQuery = "[Get_MachineByID] {0}";
                object[] parameters = { ItemId };
                ERPDataService<MachineMaster_Model> erpServ = new ERPDataService<MachineMaster_Model>();

                objMaster = (from each in erpServ.GetAll(spQuery, parameters)
                             select new MachineMaster_Model
                             {
                                 MachineID = each.MachineID,
                                 MachineName = each.MachineName,
                                 MachineDesc = each.MachineDesc,
                                 InstallDate = each.InstallDate,
                                 MCLife = each.MCLife,
                                 WarrantyPeriod = each.WarrantyPeriod,
                                 OilRequired = each.OilRequired,
                                 PowerRequired = each.PowerRequired,
                                 StandardOutputQTY = each.StandardOutputQTY,
                                 StandardOutputUnit = each.StandardOutputUnit,
                                 StandardRunningTime = each.StandardRunningTime,
                                 CreatedBy = each.CreatedBy,
                                 CreatedDateTime = each.CreatedDateTime,
                                 ModifiedBy = each.ModifiedBy,
                                 ModifiedDateTime = each.ModifiedDateTime
                             }).FirstOrDefault<MachineMaster_Model>();

            }
            catch (Exception)
            {

                throw;
            }
            return objMaster;
        }
    }
}
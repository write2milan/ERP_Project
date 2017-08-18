using ERP_WebDesign_Main.Model_DAL;
using ERP_WebDesign_Main.Models.MasterData_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class LabourMaster_BL
    {
        public IEnumerable<LabourMaster_Model> GetAllItems(object[] parameters)
        {
            IEnumerable<LabourMaster_Model> objMasterCollection = null;
            try
            {
                ERPDataService<LabourMaster_Model> erpServ = new ERPDataService<LabourMaster_Model>();
                string spQuery = "[Get_AllLabours]";
                objMasterCollection = (from each in erpServ.GetAll(spQuery, parameters)
                                       select new LabourMaster_Model
                                       {
                                           LabourID = each.LabourID,
                                           Name = each.Name,
                                           Address = each.Address,
                                           Contact = each.Contact,
                                           DailyWage = each.DailyWage,
                                           DailyWageFrequency = each.DailyWageFrequency,
                                           OTHourlyRate = each.OTHourlyRate,
                                           SkillSet = each.SkillSet,
                                           StandardWorkingHr = each.StandardWorkingHr,
                                           Shift = each.Shift,
                                           Role = each.Role,
                                           CreatedBy = each.CreatedBy,
                                           CreatedDateTime = each.CreatedDateTime,
                                           ModifiedBy = each.ModifiedBy,
                                           ModifiedDateTime = each.ModifiedDateTime
                                       }).ToList<LabourMaster_Model>();


            }
            catch (Exception)
            {

                throw;
            }

            return objMasterCollection;


        }
        public object InsertData(LabourMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Create_Labour] {0}, {1}, {2}, {3}, {4}, {5},{6}, {7}, {8}, {9}, {10}, {11},{12}, {13}";
                object[] parameters = {
                                            entity.Name,
                                            entity.Address,
                                            entity.Contact,
                                            entity.DailyWage,
                                            entity.DailyWageFrequency,
                                            entity.OTHourlyRate,
                                            entity.SkillSet,
                                            entity.StandardWorkingHr,
                                            entity.Shift,
                                            entity.Role,

                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                        DateTime.Now,
                                       };
                ERPDataService<LabourMaster_Model> erpServ = new ERPDataService<LabourMaster_Model>();
                result = erpServ.Insert(spQuery, parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
        public object UpdateData(LabourMaster_Model entity)
        {
            try
            {
                int result = 0;
                string spQuery = "[Update_Labour] {0}, {1}, {2}, {3}, {4}, {5},{6}, {7}, {8}, {9}, {10}, {11},{12}";
                object[] parameters = {
                                            entity.LabourID ,
                                            entity.Name,
                                            entity.Address,
                                            entity.Contact,
                                            entity.DailyWage,
                                            entity.DailyWageFrequency,
                                            entity.OTHourlyRate,
                                            entity.SkillSet,
                                            entity.StandardWorkingHr,
                                            entity.Shift,
                                            entity.Role,
                                        CommonHelper.CommonHelper.CurrentUserLoginName(),
                                        DateTime.Now,
                                       };
                ERPDataService<LabourMaster_Model> erpServ = new ERPDataService<LabourMaster_Model>();
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
        public LabourMaster_Model DetailsData(string ItemId)
        {
            LabourMaster_Model objMaster = new LabourMaster_Model();
            try
            {
                string spQuery = "[Get_LabourByID] {0}";
                object[] parameters = { ItemId };
                ERPDataService<LabourMaster_Model> erpServ = new ERPDataService<LabourMaster_Model>();

                objMaster = (from each in erpServ.GetAll(spQuery, parameters)
                             select new LabourMaster_Model
                             {
                                 LabourID  = each.LabourID,
                                 Name = each.Name,
                                 Address = each.Address,
                                 Contact = each.Contact,
                                 DailyWage = each.DailyWage,
                                 DailyWageFrequency = each.DailyWageFrequency,
                                 OTHourlyRate = each.OTHourlyRate,
                                 SkillSet = each.SkillSet,
                                 StandardWorkingHr = each.StandardWorkingHr,
                                 Shift = each.Shift,
                                 Role = each.Role,
                                 CreatedBy = each.CreatedBy,
                                 CreatedDateTime = each.CreatedDateTime,
                                 ModifiedBy = each.ModifiedBy,
                                 ModifiedDateTime = each.ModifiedDateTime
                             }).FirstOrDefault<LabourMaster_Model>();

            }
            catch (Exception)
            {

                throw;
            }
            return objMaster;
        }
    }
}
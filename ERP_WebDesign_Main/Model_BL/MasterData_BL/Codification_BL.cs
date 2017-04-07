using ERP_WebDesign_Main.Model_Entity_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_WebDesign_Main.Models.MasterData_Model;

namespace ERP_WebDesign_Main.Model_BL.MasterData_BL
{
    public class Codification_BL : Base_BL<Models.MasterData_Model.Codification_Model>
    {
        public override IEnumerable<Codification_Model> GetAllItems()
        {
            throw new NotImplementedException();
        }
        public override void InsertData(Codification_Model entity)
        {
            throw new NotImplementedException();
        }
        public override void DeleteData(string ItemId)
        {
            throw new NotImplementedException();
        }
        public override Codification_Model DetailsData(string ItemId)
        {
            throw new NotImplementedException();
        }
        public override void UpdateData(string ItemId, Codification_Model entity)
        {
            throw new NotImplementedException();
        }

        public Codification_Model BindModelForInsertion()
        {
            Codification_Model objCodeModel = new Codification_Model();
            try
            {
                objCodeModel.Groups = PopulateGroupsDropdown();
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
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objGrps;
        }
    }
}
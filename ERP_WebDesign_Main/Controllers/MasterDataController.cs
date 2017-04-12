using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ERP_WebDesign_Main.Controllers
{
    [AuthenticationFilter]
    public class MasterDataController : BaseController
    {
        #region Product master
        public ActionResult ProductMaster_Index()
        {
            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            return View(objProductMasterBL.GetAllItems());
        }

        public ActionResult ProductMaster_Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductMaster_Create(Models.MasterData_Model.ProductMaster_Model collection)
        {
            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            objProductMasterBL.InsertData(collection);
            return Json("/MasterData/ProductMaster_Index", JsonRequestBehavior.AllowGet);
        }


        public ActionResult ProductMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            return View(objProductMasterBL.DetailsData(ItemId));
        }


        [HttpPost]
        public ActionResult ProductMaster_Edit(Models.MasterData_Model.ProductMaster_Model Entity)
        {

            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            objProductMasterBL.UpdateData(Entity.ProductID, Entity);
            return Json("/MasterData/ProductMaster_Index", JsonRequestBehavior.AllowGet);

        }
        #endregion

        #region Codification master
        public ActionResult CodificationMaster_Index()
        {
            Model_BL.MasterData_BL.Codification_BL objCodiMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            return View(objCodiMasterBL.GetAllItems());
        }

        public ActionResult CodificationMaster_Create()
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            return View(objCodificationMasterBL.BindModelForInsertion());
        }

        public ActionResult CodificationMaster_Edit(string CodiId)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            return View(objCodificationMasterBL.DetailsData(CodiId));
        }
        [HttpPost]
        public JsonResult CodificationMaster_Edit(Models.MasterData_Model.Codification_Model Entity)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            objCodificationMasterBL.UpdateData(Entity.CodificationID, Entity);
            return Json("/MasterData/CodificationMaster_Index", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CodificationMaster_Create(Models.MasterData_Model.Codification_Model objModel)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            objCodificationMasterBL.InsertData(objModel);
            return Json("/MasterData/CodificationMaster_Index", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult PopulateCodiItems(string grpId)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            return Json(objCodificationMasterBL.PopulateItemsDropdown(grpId), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult PopulateCodiSpecs(string itemId)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            return Json(objCodificationMasterBL.PopulateSpecDropdown(itemId), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Group master
        public ActionResult GroupsMaster_Index()
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            return View(objMasterBL.GetAllItems());
        }

        public ActionResult GroupsMaster_Create()
        {
            return View();
        }

        public ActionResult GroupsMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            return View(objMasterBL.DetailsData(ItemId));
        }
        [HttpPost]
        public JsonResult GroupsMaster_Edit(Models.MasterData_Model.GroupsMaster_Model Entity)
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            objMasterBL.UpdateData(Entity.GroupID, Entity);
            return Json("/MasterData/GroupsMaster_Index", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GroupsMaster_Create(Models.MasterData_Model.GroupsMaster_Model objModel)
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            objMasterBL.InsertData(objModel);
            return Json("/MasterData/GroupsMaster_Index", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult IsExistCodeGroups(string code)
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            return Json((new JavaScriptSerializer()).Serialize(objMasterBL.ExistCode(code)), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Rack master
        public ActionResult RackMaster_Index()
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            return View(objMasterBL.GetAllItems());
        }

        public ActionResult RackMaster_Create()
        {
            return View();
        }

        public ActionResult RackMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            return View(objMasterBL.DetailsData(ItemId));
        }
        [HttpPost]
        public JsonResult RackMaster_Edit(Models.MasterData_Model.RackMaster_Model Entity)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            objMasterBL.UpdateData(Entity.RackID, Entity);
            return Json("/MasterData/RackMaster_Index", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult RackMaster_Create(Models.MasterData_Model.RackMaster_Model objModel)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            objMasterBL.InsertData(objModel);
            return Json("/MasterData/RackMaster_Index", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult IsExistCodeRacks(string code)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            return Json((new JavaScriptSerializer()).Serialize(objMasterBL.ExistCode(code)), JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}

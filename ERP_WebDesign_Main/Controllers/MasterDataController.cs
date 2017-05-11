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
        [ValidateInput(false)]
        public ActionResult ProductMaster_Create(Models.MasterData_Model.ProductMaster_Model collection)
        {
            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            objProductMasterBL.InsertData(collection);
            return Json(Url.Action("ProductMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }


        public ActionResult ProductMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            return View(objProductMasterBL.DetailsData(ItemId));
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProductMaster_Edit(Models.MasterData_Model.ProductMaster_Model Entity)
        {

            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            objProductMasterBL.UpdateData(Entity.ProductID, Entity);
            return Json(Url.Action("ProductMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);

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
            return Json(Url.Action("CodificationMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CodificationMaster_Create(Models.MasterData_Model.Codification_Model objModel)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            objCodificationMasterBL.InsertData(objModel);
            return Json(Url.Action("CodificationMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
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
        [ValidateInput(false)]
        public JsonResult GroupsMaster_Edit(Models.MasterData_Model.GroupsMaster_Model Entity)
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            objMasterBL.UpdateData(Entity.GroupID, Entity);
            return Json(Url.Action("GroupsMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult GroupsMaster_Create(Models.MasterData_Model.GroupsMaster_Model objModel)
        {
            Model_BL.MasterData_BL.GroupsMaster_BL objMasterBL = new Model_BL.MasterData_BL.GroupsMaster_BL();
            objMasterBL.InsertData(objModel);
            return Json(Url.Action("GroupsMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
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
        [ValidateInput(false)]
        public JsonResult RackMaster_Edit(Models.MasterData_Model.RackMaster_Model Entity)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            objMasterBL.UpdateData(Entity.RackID, Entity);
            return Json(Url.Action("RackMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult RackMaster_Create(Models.MasterData_Model.RackMaster_Model objModel)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            objMasterBL.InsertData(objModel);
            return Json(Url.Action("RackMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult IsExistCodeRacks(string code)
        {
            Model_BL.MasterData_BL.RackMaster_BL objMasterBL = new Model_BL.MasterData_BL.RackMaster_BL();
            return Json((new JavaScriptSerializer()).Serialize(objMasterBL.ExistCode(code)), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Item master
        public ActionResult ItemsMaster_Index()
        {
            Model_BL.MasterData_BL.ItemsMaster_BL objMasterBL = new Model_BL.MasterData_BL.ItemsMaster_BL();
            return View(objMasterBL.GetAllItems());
        }
        public ActionResult ItemsMaster_Create()
        {
            Model_BL.MasterData_BL.ItemsMaster_BL objMasterBL = new Model_BL.MasterData_BL.ItemsMaster_BL();
            return View(objMasterBL.BindModelForInsertion());
        }
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult ItemsMaster_Create(Models.MasterData_Model.ItemsMaster_Model objModel)
        {
            Model_BL.MasterData_BL.ItemsMaster_BL objMasterBL = new Model_BL.MasterData_BL.ItemsMaster_BL();
            objMasterBL.InsertData(objModel);
            return Json(Url.Action("ItemsMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ItemsMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.ItemsMaster_BL objMasterBL = new Model_BL.MasterData_BL.ItemsMaster_BL();
            return View(objMasterBL.DetailsData(ItemId));
        }
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult ItemsMaster_Edit(Models.MasterData_Model.ItemsMaster_Model Entity)
        {
            Model_BL.MasterData_BL.ItemsMaster_BL objMasterBL = new Model_BL.MasterData_BL.ItemsMaster_BL();
            objMasterBL.UpdateData(Entity.ItemID, Entity);
            return Json(Url.Action("ItemsMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult IsExistCodeItems(string code)
        {
            Model_BL.MasterData_BL.ItemsMaster_BL objMasterBL = new Model_BL.MasterData_BL.ItemsMaster_BL();
            return Json((new JavaScriptSerializer()).Serialize(objMasterBL.ExistCode(code)), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Specification master
        public ActionResult SpecificationMaster_Index()
        {
            Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
            return View(objMasterBL.GetAllItems());
        }
        public ActionResult SpecificationMaster_Create()
        {
            Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
            return View(objMasterBL.BindModelForInsertion());
        }
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult SpecificationMaster_Create(Models.MasterData_Model.SpecificationMaster_Model objModel)
        {
            if (ModelState.IsValid)
            {
                Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
                objMasterBL.InsertData(objModel);
                return Json(Url.Action("SpecificationMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
            }
            else
            {
                var errors = CommonHelper.CommonHelper.GetValidationErrorsFromModel(ModelState);
                return Json(new { errors });
            }
        }
        public ActionResult SpecificationMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
            return View(objMasterBL.DetailsData(ItemId));
        }
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult SpecificationMaster_Edit(Models.MasterData_Model.SpecificationMaster_Model Entity)
        {
            if (ModelState.IsValid)
            {
                Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
                objMasterBL.UpdateData(Entity.SpecificationID, Entity);
                return Json(Url.Action("SpecificationMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
            }
            else
            {
                var errors = CommonHelper.CommonHelper.GetValidationErrorsFromModel(ModelState);
                return Json(new { errors });
            }
        }
        [HttpPost]
        public JsonResult IsExistSpecItems(string code)
        {
            Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
            return Json((new JavaScriptSerializer()).Serialize(objMasterBL.ExistCode(code)), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult PopulateSpecItems(string grpId)
        {
            Model_BL.MasterData_BL.SpecificationMaster_BL objMasterBL = new Model_BL.MasterData_BL.SpecificationMaster_BL();
            return Json(objMasterBL.PopulateItemsDropdown(grpId), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Process master
        public ActionResult ProcessMaster_Index()
        {
            Model_BL.MasterData_BL.ProcessMaster_BL objProcessMasterBL = new Model_BL.MasterData_BL.ProcessMaster_BL();
            object[] parameters = { };
            return View(objProcessMasterBL.GetAllItems(parameters));
        }
        public ActionResult ProcessMaster_Create()
        {
            Model_BL.MasterData_BL.ProcessMaster_BL objProcessMasterBL = new Model_BL.MasterData_BL.ProcessMaster_BL();
            return View(objProcessMasterBL.BindModelForInsertion());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProcessMaster_Create(Models.MasterData_Model.ProcessMaster_Model collection)
        {
            Model_BL.MasterData_BL.ProcessMaster_BL objProcessMasterBL = new Model_BL.MasterData_BL.ProcessMaster_BL();
            objProcessMasterBL.InsertData(collection);
            return Json(Url.Action("ProcessMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProcessMaster_Edit(string ItemId)
        {
            Model_BL.MasterData_BL.ProcessMaster_BL objProcessMasterBL = new Model_BL.MasterData_BL.ProcessMaster_BL();
            return View(objProcessMasterBL.DetailsData(ItemId));
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProcessMaster_Edit(Models.MasterData_Model.ProcessMaster_Model Entity)
        {

            Model_BL.MasterData_BL.ProcessMaster_BL objProcessMasterBL = new Model_BL.MasterData_BL.ProcessMaster_BL();
            objProcessMasterBL.UpdateData( Entity);
            return Json(Url.Action("ProcessMaster_Index", "MasterData"), JsonRequestBehavior.AllowGet);

        }
        public ActionResult ProcessMaster_Details(string ItemId)
        {
            Model_BL.MasterData_BL.ProcessMaster_BL objProcessMasterBL = new Model_BL.MasterData_BL.ProcessMaster_BL();
            return View(objProcessMasterBL.DetailsData(ItemId));
        }
        #endregion

    }
}

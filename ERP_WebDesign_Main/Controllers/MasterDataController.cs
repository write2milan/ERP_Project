using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Controllers
{
    [AuthenticationFilter]
    public class MasterDataController : BaseController
    {
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
            return RedirectToAction("ProductMaster_Index");
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
            return RedirectToAction("ProductMaster_Index");

        }

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
            return Json("", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CodificationMaster_Create(Models.MasterData_Model.Codification_Model objModel)
        {
            Model_BL.MasterData_BL.Codification_BL objCodificationMasterBL = new Model_BL.MasterData_BL.Codification_BL();
            objCodificationMasterBL.InsertData(objModel);
            return Json("", JsonRequestBehavior.AllowGet);
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




    }
}

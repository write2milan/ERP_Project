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


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_WebDesign_Main.Controllers
{
    public class MasterDataController : BaseController
    {
        // GET: MasterData
        [AuthenticationFilter]
        public ActionResult ProductMaster_Index()
        {
            Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
            return View(objProductMasterBL.GetAllItems());
        }

        // GET: MasterData/Details/5
        [AuthenticationFilter]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasterData/Create
        [AuthenticationFilter]
        public ActionResult ProductMaster_Create()
        {
            //Models.MasterData_Model.ProductMaster_Model collection = new Models.MasterData_Model.ProductMaster_Model();
            return View();
        }

        // POST: MasterData/Create
        [AuthenticationFilter]
        [HttpPost]
        public ActionResult ProductMaster_Create(Models.MasterData_Model.ProductMaster_Model collection)
        {
            try
            {
                // TODO: Add insert logic here
                Model_BL.MasterData_BL.ProductMaster_BL objProductMasterBL = new Model_BL.MasterData_BL.ProductMaster_BL();
                objProductMasterBL.InsertData(collection);
                return RedirectToAction("ProductMaster_Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterData/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: MasterData/Edit/5
        [AuthenticationFilter]
        [HttpPost]
        public ActionResult ProductMaster_Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterData/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: MasterData/Delete/5
        [AuthenticationFilter]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

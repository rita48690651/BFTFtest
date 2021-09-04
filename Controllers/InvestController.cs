using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BFTFtest.Models;

namespace BFTFtest.Controllers
{
    public class InvestController : Controller
    {
        private DBModel db = new DBModel();
        // GET: Invest
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult GetData()
        //{
        //    using (DBModel db = new DBModel())
        //    {
        //        List<Transfer> transferList = db.Transfer.ToList<Validation>();
        //        return Json(new { data = transferList }, JsonRequestBehavior.AllowGet);
        //    }
        //}
    }
}
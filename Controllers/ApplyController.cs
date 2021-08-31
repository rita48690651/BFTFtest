using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BFTFtest.Models;

namespace BFTFtest.Controllers
{
    public class ApplyController : Controller
    {
        // GET: Apply
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<Apply> empList = db.Apply.ToList<Apply>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
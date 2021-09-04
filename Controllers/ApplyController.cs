using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BFTFtest.Models;


namespace BFTFtest.Controllers
{
    public class ApplyController : Controller
    {
        private DBModel db = new DBModel();
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

        //用不到但先留著
        //[HttpGet]
        //public ActionResult AddOrEdit(int id = 0)
        //{
        //    if (id == 0)
        //        return View(new Apply());
        //    else
        //    {
        //        using (DBModel db = new DBModel())
        //        {
        //            return View(db.Apply.Where(x => x.EventId == id).FirstOrDefault<Apply>());
        //        }
        //    }

        //    return View(new Apply());
        //}


        //用不到但先留著
        //[HttpPost]
        //public ActionResult AddOrEdit(Apply emp)
        //{
        //    using (DBModel db = new DBModel())
        //    {
        //        if (emp.EventId == 0)
        //        {
        //            db.Apply.Add(emp);
        //            db.SaveChanges();
        //            return Json(new { success = true, message = "Saved Successfully" }, JsonRequestBehavior.AllowGet);
        //    }
        //        else
        //    {
        //        db.Entry(emp).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return Json(new { success = true, message = "Updated Successfully" }, JsonRequestBehavior.AllowGet);
        //    }
        //}
        //}

        public ActionResult Main()//介紹借款流程、須知
        {
            return View();
        }

        

        public ActionResult Calculate()//貸款試算
        {
            return View();
        }

        public ActionResult Create()//填寫申貸表
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,School,Reason,Money,Rate,Period,CreditScore")] Apply apply)
        {
            if (ModelState.IsValid)
            {
                db.Apply.Add(apply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apply);
        }

        [HttpGet]//上傳身分證、學生證照(身分驗證)
        public ActionResult Add()
        {
            return View();
        }

        
        //[HttpPost]
        //public ActionResult Add(Validation imageModel)
        //{
        //    string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
        //    string extension = Path.GetExtension(imageModel.ImageFile.FileName);
        //    fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
        //    imageModel.IdCardPicture = "~/Image/" + fileName;
        //    fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
        //    imageModel.ImageFile.SaveAs(fileName);
        //    using (DBModel db = new DBModel())
        //    {
        //        db.Validates.Add = (imageModel);
        //        db.SaveChanges();
        //    }
        //    ModelState.Clear();
        //    return View();
        //}

    }
}
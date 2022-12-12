using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataShop.EF;

namespace Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers
{
    public class ProvidersController : BaseController
    {
        private WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();

        // GET: Admin/Providers
        public ActionResult Index()
        {
            return View(db.Providers.ToList());
        }
        public JsonResult GetByID(long id)
        {
            var ncc = db.Providers.Where(x => x.PrvID == id).FirstOrDefault();
            return Json(ncc, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Providers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Providers.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // GET: Admin/Providers/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create(Provider p)
        {
            db.Providers.Add(p);
            db.SaveChanges();
            SetAlert("Thêm nhà cung cấp thành công", "success");
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // POST: Admin/Providers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "PrvID,PrvName,Address,Phone,Email")] Provider provider)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Providers.Add(provider);
        //        db.SaveChanges();
        //        SetAlert("Thêm nhà cung cấp thành công", "success");
        //        return RedirectToAction("Index");
        //    }

        //    return View(provider);
        //}

        // GET: Admin/Providers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Providers.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // POST: Admin/Providers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "PrvID,PrvName,Address,Phone,Email")] Provider provider)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(provider).State = EntityState.Modified;
        //        db.SaveChanges();
        //        SetAlert("Sửa nhà cung cấp thành công", "success");
        //        return RedirectToAction("Index");
        //    }
        //    return View(provider);
        //}

        public JsonResult Edit(Provider ncc)
        {
            //var ncccu = db.Providers.Where(x => x.PrvID == ncc.PrvID).FirstOrDefault();
            //db.Entry(ncccu).CurrentValues.SetValues(ncc);
            db.Entry(ncc).State = EntityState.Modified;
            db.SaveChanges();
            SetAlert("Sửa nhà cung cấp thành công", "success");
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Providers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Providers.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // POST: Admin/Providers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Provider provider = db.Providers.Find(id);
            db.Providers.Remove(provider);
            db.SaveChanges();
            SetAlert("Xoá nhà cung cấp thành công", "success");
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public JsonResult DeleteObj(long id)
        {
            var ncc = db.Providers.Where(x => x.PrvID == id).FirstOrDefault();
            db.Providers.Remove(ncc);
            db.SaveChanges();
            SetAlert("Xoá nhà cung cấp thành công", "success");
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

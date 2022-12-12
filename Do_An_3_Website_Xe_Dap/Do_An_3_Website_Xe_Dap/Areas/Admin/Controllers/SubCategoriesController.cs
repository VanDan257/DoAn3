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
    public class SubCategoriesController : BaseController
    {
        private WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();

        // GET: Admin/SubCategories
        public ActionResult Index()
        {
            var subCategories = db.SubCategories.Include(s => s.Category);
            return View(subCategories.ToList());
        }

        // GET: Admin/SubCategories/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = db.SubCategories.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            return View(subCategory);
        }

        // GET: Admin/SubCategories/Create
        public ActionResult Create()
        {
            ViewBag.CateID = new SelectList(db.Categories, "CateID", "CateName");
            return View();
        }

        // POST: Admin/SubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubCateID,CateID,SubCateName")] SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                db.SubCategories.Add(subCategory);
                db.SaveChanges();
                SetAlert("Thêm danh mục con thành công", "success");
                return RedirectToAction("Index");
            }

            ViewBag.CateID = new SelectList(db.Categories, "CateID", "CateName", subCategory.CateID);
            return View(subCategory);
        }

        // GET: Admin/SubCategories/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = db.SubCategories.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.CateID = new SelectList(db.Categories, "CateID", "CateName", subCategory.CateID);
            return View(subCategory);
        }

        // POST: Admin/SubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubCateID,CateID,SubCateName")] SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subCategory).State = EntityState.Modified;
                db.SaveChanges();
                SetAlert("Sửa danh mục con thành công", "success");
                return RedirectToAction("Index");
            }
            ViewBag.CateID = new SelectList(db.Categories, "CateID", "CateName", subCategory.CateID);
            return View(subCategory);
        }

        // GET: Admin/SubCategories/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = db.SubCategories.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            return View(subCategory);
        }

        // POST: Admin/SubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SubCategory subCategory = db.SubCategories.Find(id);
            db.SubCategories.Remove(subCategory);
            db.SaveChanges();
            SetAlert("Xoá danh mục con thành công", "success");
            return RedirectToAction("Index");
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

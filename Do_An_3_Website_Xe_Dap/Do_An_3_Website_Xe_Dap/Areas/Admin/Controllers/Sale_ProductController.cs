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
    public class Sale_ProductController : Controller
    {
        private WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();

        // GET: Admin/Sale_Product
        public ActionResult Index()
        {
            var sale_Product = db.Sale_Product.Include(s => s.Product);
            return View(sale_Product.ToList());
        }

        // GET: Admin/Sale_Product/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale_Product sale_Product = db.Sale_Product.Find(id);
            if (sale_Product == null)
            {
                return HttpNotFound();
            }
            return View(sale_Product);
        }

        // GET: Admin/Sale_Product/Create
        public ActionResult Create()
        {
            ViewBag.ProID = new SelectList(db.Products, "ProID", "Title");
            return View();
        }

        // POST: Admin/Sale_Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sale_ID,ProID,OldPrice,SalePrice")] Sale_Product sale_Product)
        {
            if (ModelState.IsValid)
            {
                db.Sale_Product.Add(sale_Product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProID = new SelectList(db.Products, "ProID", "Title", sale_Product.ProID);
            return View(sale_Product);
        }

        // GET: Admin/Sale_Product/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale_Product sale_Product = db.Sale_Product.Find(id);
            if (sale_Product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProID = new SelectList(db.Products, "ProID", "Title", sale_Product.ProID);
            return View(sale_Product);
        }

        // POST: Admin/Sale_Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sale_ID,ProID,OldPrice,SalePrice")] Sale_Product sale_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale_Product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProID = new SelectList(db.Products, "ProID", "Title", sale_Product.ProID);
            return View(sale_Product);
        }

        // GET: Admin/Sale_Product/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale_Product sale_Product = db.Sale_Product.Find(id);
            if (sale_Product == null)
            {
                return HttpNotFound();
            }
            return View(sale_Product);
        }

        // POST: Admin/Sale_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Sale_Product sale_Product = db.Sale_Product.Find(id);
            db.Sale_Product.Remove(sale_Product);
            db.SaveChanges();
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataShop.EF;
using Newtonsoft.Json;

namespace Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers
{
    public class ProductsController : BaseController
    {
        private WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();

        // GET: Admin/Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products.ToList());
        }
        public JsonResult GetByID(long id)
        {
            var sp = db.Products.Select(s => new { s.ProID, s.Title, s.Color, s.Desscription, s.Image, s.MoreImages, s.Price, s.PromotionPrice, s.Quantity }).FirstOrDefault(s => s.ProID == id);
            return Json(sp, JsonRequestBehavior.AllowGet);
        }

        public ContentResult GetTenDM()
        {
            var ds = db.Categories.Select(s => new { s.CateID, s.CateName }).ToList();
            var list = JsonConvert.SerializeObject(ds,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
            //return Json(ds, JsonRequestBehavior.AllowGet);

        }

        public ContentResult GetAll()
        {
            var ds = db.Products.Select(s => new { s.ProID, s.Title, s.Color, s.Desscription, s.Image, s.MoreImages, s.Price, s.PromotionPrice, s.Quantity }).ToList();
            var list = JsonConvert.SerializeObject(ds,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
            //return Json(ds, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Products/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Admin/Products/Create
        public ActionResult Create()
        {
            ViewBag.CateID = new SelectList(db.Categories, "CateID", "CateName");
            return View();
        }

        [HttpPost]
        public JsonResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            SetAlert("Thêm sản phẩm thành công", "success");

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Products/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CateID = new SelectList(db.Categories, "CateID", "CateName", product.CateID);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            SetAlert("Sửa sản phẩm thành công", "success");

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Products/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            SetAlert("Xoá sản phẩm thành công", "success");
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataShop.EF;
using Newtonsoft.Json;

namespace Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers
{
    public class CustomersController : BaseController
    {
        private WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();

        // GET: Admin/Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        public ContentResult GetAll()
        {
            var ds = db.Customers.Select(s => new { s.CusID, s.CusName, s.Phone, s.Email, s.Address, s.Image, s.UserName, s.Password }).ToList();
            var list = JsonConvert.SerializeObject(ds,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
            //return Json(ds, JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Customers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Admin/Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CusID,CusName,Phone,Email,Address,UserName,Password,Image")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                SetAlert("Thêm khách hàng thành công", "success");
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Admin/Customers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Admin/Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CusID,CusName,Phone,Email,Address,UserName,Password,Image")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                SetAlert("Sửa khách hàng thành công", "success");
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Admin/Customers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Admin/Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            SetAlert("Xoá khách hàng thành công", "success");
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

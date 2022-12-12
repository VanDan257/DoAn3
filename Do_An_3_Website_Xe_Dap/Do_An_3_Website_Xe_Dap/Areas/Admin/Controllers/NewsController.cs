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
    public class NewsController : BaseController
    {
        private WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();

        // GET: Admin/News
        public ActionResult Index()
        {
            var news = db.News.Include(n => n.User);
            return View(news.ToList());
        }

        public ContentResult GetAll()
        {
            var ds = db.News.Select(s => new { s.NewsID, s.Title, s.UserID, s.PublicDate, s.Content, s.Image }).ToList();
            var list = JsonConvert.SerializeObject(ds,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
            //return Json(ds, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetByID(long id)
        {
            var news = db.News.Select(s => new { s.NewsID, s.Title, s.UserID, s.PublicDate, s.Content, s.Image }).FirstOrDefault(s => s.NewsID == id);

            return Json(news, JsonRequestBehavior.AllowGet);
            //return Json(ds, JsonRequestBehavior.AllowGet);
        }


        public ContentResult GetNV()
        {
            var ds = db.Users.Select(s => new { s.UserID, s.FullName }).ToList();
            var list = JsonConvert.SerializeObject(ds,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
            //return Json(ds, JsonRequestBehavior.AllowGet);

        }

        // GET: Admin/News/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // GET: Admin/News/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");
            return View();
        }

        // POST: Admin/News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Create(News news)
        {
            //string _FileName = "";
            //string _path = "";
            //try
            //{
            //    if (file1.ContentLength > 0)
            //    {
            //        _FileName = Path.GetFileName(file1.FileName);
            //        _path = Path.Combine(Server.MapPath("~/FileUpLoad/"), _FileName);
            //        file1.SaveAs(_path);
            //    }
            //}
            //catch
            //{

            //}
            news.PublicDate = DateTime.Today;
            db.News.Add(news);
            db.SaveChanges();
            SetAlert("Thêm tin thành công", "success");
            //return RedirectToAction("Index");

            //ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", news.UserID);
            return Json(true, JsonRequestBehavior.AllowGet);
            //return View(news);
        }

        // GET: Admin/News/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", news.UserID);
            return View(news);
        }

        // POST: Admin/News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Edit(News news)
        {
            //if (ModelState.IsValid)
            //{


            db.Entry(news).State = EntityState.Modified;
            db.SaveChanges();
            SetAlert("Sửa tin thành công", "success");
            return Json(true, JsonRequestBehavior.AllowGet);


            //    return RedirectToAction("Index", "News");
            //}
            //ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", news.UserID);
            //return View(news);
        }

        // GET: Admin/News/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // POST: Admin/News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            News news = db.News.Find(id);
            db.News.Remove(news);
            db.SaveChanges();
            SetAlert("Xoá tin thành công", "success");
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

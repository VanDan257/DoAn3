using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataShop.Dao;
using DataShop.EF;
using Do_An_3_Website_Xe_Dap.Common;
using Do_An_3_Website_Xe_Dap.Areas.Admin.Models;

namespace Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers
{
    public class TrangQuanTriController : BaseController
    {
        WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();
        // GET: Admin/Home
        public ActionResult Index()
        {
            //var user = db.Users.FirstOrDefault(s => s.UserID == id);
            var user = Session[CommonConstants.USER_SESSION];
            var tk = new LoginModel();
            User qtv = new User();
            if (user != null)
            {
                tk = (LoginModel)user;
                var dao = new UserDao();
                qtv = dao.GetById(tk.UserName);
            }
            ViewBag.qtv = qtv;
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult HeaderUser()
        {
            var user = Session[CommonConstants.USER_SESSION];
            var tk = new LoginModel();
            User qtv = new User();
            if (user != null)
            {
                tk = (LoginModel)user;
                var dao = new UserDao();
                qtv = dao.GetById(tk.UserName);
            }
            ViewBag.qtv = qtv;
            return PartialView();
        }
    }
}
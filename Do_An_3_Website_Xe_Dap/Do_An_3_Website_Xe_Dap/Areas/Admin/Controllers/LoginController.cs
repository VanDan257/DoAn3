using Do_An_3_Website_Xe_Dap.Areas.Admin.Models;
using DataShop.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do_An_3_Website_Xe_Dap.Common;

namespace Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.Password);
                if (result)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new LoginModel();
                    userSession.UserName = user.UserName;
                    Session.Add(CommonConstants.USER_SESSION,userSession);
                    return RedirectToAction("Index", "TrangQuanTri");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
    }
}
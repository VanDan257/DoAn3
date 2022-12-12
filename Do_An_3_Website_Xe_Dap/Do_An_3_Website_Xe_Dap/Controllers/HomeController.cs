using DataShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataShop;
using System.Web.Script.Serialization;
using Do_An_3_Website_Xe_Dap.Models;
using DataShop.Dao;
using Antlr.Runtime;
using Do_An_3_Website_Xe_Dap.Common;
using Newtonsoft.Json;

namespace Do_An_3_Website_Xe_Dap.Controllers
{
    public class HomeController : Controller
    {
        private const string CartSession = "CartSession";
        WebsiteXeDapMVCEntities db = new WebsiteXeDapMVCEntities();
        public ActionResult TrangChu()
        {
            // ViewBag.listCate = db.Categories.ToList();
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        protected void ToastMessage(string message, string type)
        {
            TempData["ToastMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success success";
            }
            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger danger";
            }
        }

        public ContentResult GetProduct()
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

        [ChildActionOnly]
        public PartialViewResult MenuCategory()
        {
            List<Category> cate = db.Categories.ToList();
            return PartialView(cate);
        }

        public ActionResult DanhMucSanPham()
        {
            // ViewBag.listCate = db.Categories.ToList();
            ViewBag.listNCC = db.Providers.ToList();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
        public ActionResult themgh(int id)
        {
            List<Product> ds = db.Products.ToList();
            var sanpham = ds.FirstOrDefault(s => s.ProID == id);
            if (Session[CartSession] == null)
            {
                List<OrderDetail> ls = new List<OrderDetail>();

                ls.Add(new OrderDetail()
                {
                    ProID = id,
                    Quantity = 1,
                    Product = sanpham,
                    Price = (double?)sanpham.Price
                });
                Session[CartSession] = ls;
            }
            else
            {
                List<OrderDetail> cart = (List<OrderDetail>)Session[CartSession];
                var x = ds.FirstOrDefault(s => s.ProID == id);
                var kiemtra = cart.FirstOrDefault(s => s.ProID == id);
                if (kiemtra != null)
                {
                    kiemtra.Quantity += 1;
                    Session[CartSession] = cart;
                }
                else
                {
                    OrderDetail sp = new OrderDetail();
                    sp.ProID = id;
                    sp.Price = (long?)x.Price;
                    sp.Quantity = 1;
                    sp.Product = sanpham;
                    cart.Add(sp);
                    Session[CartSession] = cart;
                }
            }
            ToastMessage("Thêm vào giỏ hàng thành công", "success");
            return RedirectToAction("DanhMucSanPham");
        }

        public ActionResult viewCart()
        {
            // ViewBag.listCate = db.Categories.ToList();
            List<OrderDetail> ds = (List<OrderDetail>)Session[CartSession];
            return View(ds);
        }

        [ChildActionOnly]
        public PartialViewResult DanhSachDonhang()
        {
            var user = Session[CommonConstants.USER_SESSIONCUS];
            var tk = new LoginModel();
            Customer customer = new Customer();
            Order order = new Order();
            List<OrderDetail> dsdh = new List<OrderDetail>();
            if (user != null)
            {
                tk = (LoginModel)user;
                var dao = new UserDao();
                customer = dao.GetByIdCustomer(tk.UserName);
                order = db.Orders.FirstOrDefault(s => s.CusID == customer.CusID);
                return PartialView(order);
            }
            return PartialView();
        }

        public ActionResult TinTuc()
        {
            // ViewBag.listCate = db.Categories.ToList();
            List<News> dstt = db.News.ToList();
            return View(dstt);
        }

        public ActionResult ThanhToan()
        {
            var cart = Session[CartSession];
            var list = new List<OrderDetail>();
            //List<OrderDetail> list = (List<OrderDetail>)Session[CartSession];
            if (cart != null)
            {
                list = (List<OrderDetail>)cart;
            }
            ViewBag.cart = list;
            ViewBag.CusID = new SelectList(db.Customers, "CusID", "CusName");
            return View();
        }

        [HttpPost]
        public ActionResult ThanhToan(string DeliveryAddress, string note, string phone, string recipient)
        {
            var cart = Session[CartSession];
            var list = new List<OrderDetail>();
            Order hd = new Order();
            OrderDetail cthd = new OrderDetail();

            //List<OrderDetail> list = (List<OrderDetail>)Session[CartSession];
            if (cart != null)
            {
                list = (List<OrderDetail>)cart;
            }

            var user = Session[CommonConstants.USER_SESSIONCUS];
            var tk = new LoginModel();
            Customer customer = new Customer();
            ViewBag.cart = list;
            ViewBag.user = user;
            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    tk = (LoginModel)user;
                    var dao = new UserDao();
                    customer = dao.GetByIdCustomer(tk.UserName);
                    double sum = 0;
                    foreach (var i in list)
                    {
                        sum += Convert.ToDouble(i.Quantity * i.Price);
                    }
                    hd.CusID = customer.CusID;
                    hd.DeliveryAddress = DeliveryAddress;
                    hd.Phone = phone;
                    hd.Recipient = recipient;
                    hd.Status = "Đang giao";
                    hd.TotalPay = (long?)sum;
                    hd.OrderDate = DateTime.Now;
                    hd.Note = note;
                    db.Orders.Add(hd);
                    db.SaveChanges();
                    foreach (var i in list)
                    {
                        cthd.OrdID = hd.OrdID;
                        cthd.ProID = i.ProID;
                        cthd.Quantity = i.Quantity;
                        cthd.Price = i.Price;
                        db.OrderDetails.Add(cthd);
                        db.SaveChanges();
                    }
                }
                else
                {
                    double sum = 0;
                    foreach (var i in list)
                    {
                        sum += Convert.ToDouble(i.Quantity * i.Price);
                    }

                    // thêm Hoá đơn vào bảng Order trong database
                    hd.DeliveryAddress = DeliveryAddress;
                    hd.Phone = phone;
                    hd.Recipient = recipient;
                    hd.Status = "Đang giao";
                    hd.TotalPay = (long?)sum;
                    hd.OrderDate = DateTime.Today;
                    hd.Note = note;
                    db.Orders.Add(hd);

                    // thêm Khách hàng vào bảng Customer trong database
                    customer.CusName = recipient;
                    customer.Address = DeliveryAddress;
                    customer.Phone = phone;
                    db.Customers.Add(customer);

                    db.SaveChanges();
                    foreach (var i in list)
                    {
                        // thêm từng Chi tiết hoá đơn vào bảng OrderDetail trong database
                        cthd.OrdID = hd.OrdID;
                        cthd.ProID = i.ProID;
                        cthd.Quantity = i.Quantity;
                        cthd.Price = (i.Price * i.Quantity);
                        db.OrderDetails.Add(cthd);
                        db.SaveChanges();
                    }
                }
                ToastMessage("Thanh toán hàng thành công!!!  Cảm ơn bạn đã mua hàng của chúng tôi", "success");
                return RedirectToAction("TrangChu", "Home");
            }
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult HeaderUser()
        {
            var user = Session[CommonConstants.USER_SESSIONCUS];
            var tk = new LoginModel();
            Customer customer = new Customer();
            if (user != null)
            {
                tk = (LoginModel)user;
                var dao = new UserDao();
                customer = dao.GetByIdCustomer(tk.UserName);
            }
            return PartialView(customer);
        }

        public ActionResult Detail(int id)
        {
            // ViewBag.listCate = db.Categories.ToList();
            var sp = db.Products.FirstOrDefault(s => s.ProID == id);
            return View(sp);
        }

        public ActionResult DangNhap()
        {
            // ViewBag.listCate = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.LoginCustomer(model.UserName, model.Password);
                if (result)
                {
                    var customer = dao.GetByIdCustomer(model.UserName);
                    var cusSession = new LoginModel();
                    cusSession.UserName = customer.UserName;
                    Session.Add(CommonConstants.USER_SESSIONCUS, cusSession);
                    return RedirectToAction("TrangChu", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
        public ActionResult DangKy()
        {
            // ViewBag.listCate = db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(RegisterModel model)
        {
            // ViewBag.listCate = db.Categories.ToList();
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckUserName(model.UserName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckUserEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var user = new Customer();
                    user.CusName = model.CusName;
                    user.UserName = model.UserName;
                    user.Password = model.Password;
                    user.Phone = model.Phone;
                    user.Email = model.Email;
                    user.Address = model.Address;
                    user.Image = model.Image;
                    var result = dao.InsertCustomer(user);
                    if (result > 0)
                    {
                        ViewBag.Success = "Đăng ký thành công";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công");
                    }
                }
                ToastMessage("Đăng ký thành công", "success");
                return RedirectToAction("DangNhap", "Home");
            }
            return View(model);
        }

        public ActionResult DangXuat()
        {
            Session[CommonConstants.USER_SESSIONCUS] = null;
            return RedirectToAction("DangNhap", "Home");
        }

        ////
        // Các sự kiện giỏ hàng 
        //Xoá 1 sản phẩm trong giỏ hàng
        public JsonResult Delete(long id)
        {
            var sessionCart = (List<OrderDetail>)Session[CartSession];
            sessionCart.RemoveAll(x => x.Product.ProID == id);
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        //Xoá tất cả sản phẩm
        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });

        }

        // Cập nhật giỏ hàng
        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<OrderDetail>>(cartModel);
            var sessionCart = (List<OrderDetail>)Session[CartSession];
            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.Product.ProID == item.Product.ProID);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public ActionResult AddItem(long proId, int quantity)
        {
            var product = db.Products.FirstOrDefault(s => s.ProID == proId);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<OrderDetail>)cart;
                if (list.Exists(x => x.Product.ProID == proId))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.ProID == proId)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    // Tạo mới đối tượng cart item
                    var item = new OrderDetail();
                    item.Product = product;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                Session[CartSession] = list;
            }
            else
            {
                // Tạo mới đối tượng cart item
                var item = new OrderDetail();
                item.Product = product;
                item.Quantity = quantity;
                var list = new List<OrderDetail>();

                // Gán vào session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
    }
}
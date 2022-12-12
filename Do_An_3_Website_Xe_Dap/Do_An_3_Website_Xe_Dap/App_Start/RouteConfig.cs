using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Do_An_3_Website_Xe_Dap
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "TrangChu",
            //    url: "Trang-Chu",
            //    defaults: new { controller = "Home", action = "TrangChu" },
            //    namespaces: new[] { "Do_An_3_Website_Xe_Dap.Controller" }
            //);

            //routes.MapRoute(
            //    name: "DanhMucSanPham",
            //    url: "Danh-Muc-San-Pham",
            //    defaults: new { controller = "Home", action = "DanhMucSanPham" },
            //    namespaces: new[] { "Do_An_3_Website_Xe_Dap.Controller" }
            //);

            //routes.MapRoute(
            //    name: "Cart",
            //    url: "Gio-Hang",
            //    defaults: new { controller = "Home", action = "viewCart" },
            //    namespaces: new[] { "Do_An_3_Website_Xe_Dap.Controller" }
            //);

            //routes.MapRoute(
            //    name: "Index",
            //    url: "Trang-Quan-Tri",
            //    defaults: new { controller = "TrangQuanTri", action = "Index" },
            //    namespaces: new[] { "Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers" }
            //);
            
            //routes.MapRoute(
            //    name: "Login",
            //    url: "Dang-Nhap",
            //    defaults: new { controller = "Login", action = "Index" },
            //    namespaces: new[] { "Do_An_3_Website_Xe_Dap.Areas.Admin.Controllers" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Do_An_3_Website_Xe_Dap.Areas.Admin.Models
{
    public class LoginModel
    {
        public long UserID { set; get; }
        [Required(ErrorMessage = "Mời nhập user name")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Mời nhập password")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }

    }
}
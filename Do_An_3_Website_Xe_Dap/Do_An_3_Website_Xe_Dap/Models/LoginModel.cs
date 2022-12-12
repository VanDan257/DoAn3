using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Do_An_3_Website_Xe_Dap.Models
{
    public class LoginModel
    {
        [Key]
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải nhập tài khoản")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập Mật khẩu")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Do_An_3_Website_Xe_Dap.Models
{
    public class RegisterModel
    {
        [Key]
        public long CusID { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [DisplayName("Tên khách hàng")]
        public string CusName { get; set; }
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Bạn chưa nhập email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tài khoản")]
        [DisplayName("Tài khoản")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [DisplayName("Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không đúng.")]
        public string ConfirmPassword { get; set; }
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }
    }
}
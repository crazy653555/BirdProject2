using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirdProject.Models
{
    public class LoginViewModel
    {
        [DisplayName("帳號")]
        [Required]
        public string Email { get; set; }

        [Required]
        [DisplayName("密碼")]
        public string Password { get; set; }
    }


    public class RegisteredViewModel
    {
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "請輸入Email")]
        [Required]
        public string Email { get; set; }

        [DisplayName("密碼")]
        [StringLength(10,ErrorMessage = "{0} 的長度需為 {2} - {1} 個字元。", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [StringLength(10, ErrorMessage = "{0} 的長度需為 {2} - {1} 個字元。", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [DisplayName("確認密碼")]
        [Required]
        public string ConfirmPassword { get; set; }

        [DisplayName("鳥奴暱稱")]
        [Required]
        public string UserName { get; set; }

        [Required]
        [DisplayName("連絡電話")]
        public string Tel { get; set; }
    }

}
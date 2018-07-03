using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirdProject.Models
{
    [MetadataType(typeof(B鳥奴Metadata))]
    public partial class B鳥奴
    {
    }

    public class B鳥奴Metadata
    {
        [DisplayName("信箱")]
        [EmailAddress(ErrorMessage ="請輸入Email")]
        public string Email { get; set; }

        [DisplayName("鳥奴暱稱")]
        [Required]
        public string UserName { get; set; }

        [Required]
        [DisplayName("連絡電話")]
        public string Tel { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
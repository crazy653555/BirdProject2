using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirdProject.Models
{
    [MetadataType(typeof(B鳥Metadata))]
    public partial class B鳥
    {
    }

    public class B鳥Metadata
    {
        public int UserId { get; set; }

        [DisplayName("認證序號")]
        public int VerificationId { get; set; }

        [DisplayName("鳥名")]
        public string BirdName { get; set; }

        [DisplayName("性別")]
        public string BirdGender { get; set; }

        [DisplayName("俗名/學名Id")]
        public Nullable<int> Bird學名Id { get; set; }

        [DisplayName("註冊時間")]
        public System.DateTime RegisteredTime { get; set; }

        [DisplayName("狀態")]
        public int StatusId { get; set; }

    }
}
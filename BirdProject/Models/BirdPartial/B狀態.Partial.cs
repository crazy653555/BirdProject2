using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirdProject.Models
{
    [MetadataType(typeof(B狀態Metadata))]
    public partial class B狀態
    {
    }

    public class B狀態Metadata
    {
        public int StatusId { get; set; }

        [DisplayName("狀態")]
        public string Type { get; set; }
    }
}
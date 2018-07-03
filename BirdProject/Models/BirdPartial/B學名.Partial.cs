using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirdProject.Models
{
    [MetadataType(typeof(B學名Metadata))]
    public partial class B學名
    {
    }

    public class B學名Metadata
    {
        public int Bird學名Id { get; set; }

        [DisplayName("俗名/學名")]
        public string Bird學名 { get; set; }
    }
}
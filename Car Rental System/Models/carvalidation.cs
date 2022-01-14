using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Rental_System.Models
{
    [MetadataType(typeof(carregMetadata))]
    public partial class carreg
    {
        public class carregMetadata
        {
            [DisplayName("Car Number")]
            public string carno { get; set; }

            [DisplayName("Make")]
            public string make { get; set; }

            [DisplayName("Model")]
            public string model { get; set; }

            [DisplayName("Available")]
            public string available { get; set; }
        }
    }
}
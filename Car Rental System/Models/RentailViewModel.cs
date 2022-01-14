using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_System.Models
{
    public class RentailViewModel
    {
        public int id { get; set; }
        public string carid { get; set; }
        public Nullable<int> custid { get; set; }
        public Nullable<int> fee { get; set; }
        public Nullable<System.DateTime> sdatre { get; set; }

        public Nullable<System.DateTime> edate { get; set; }
        public string available { get; set; }
    }
}
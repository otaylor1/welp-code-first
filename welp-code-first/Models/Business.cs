using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Business
    {
        public int BusinessID { get; set; }

        public string BusinessName { get; set; }
        public int BusinessTypeID { get; set; }
        public string Address { get; set; }
        public string Hours { get; set; }
        public string Phone { get; set; }
        public string Menu { get; set; }
        public int UserID { get; set; }


        //Navigation Properties
        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual BusinessType BusinessType { get; set; }
        public virtual User User { get; set; }
    }
}
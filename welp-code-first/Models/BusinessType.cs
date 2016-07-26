using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class BusinessType
    {
        public int BusinessTypeID { get; set; }
        public string BusinessTypeName { get; set; }


        //Navigation Properties
        public virtual ICollection<Business> Businesses { get; set; }
    }
}
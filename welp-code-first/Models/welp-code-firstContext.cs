using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace welp_code_first.Models
{
    public class welp_code_firstContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
    }
}
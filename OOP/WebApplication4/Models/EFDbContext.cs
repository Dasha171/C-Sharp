using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication4.Models.Entities;

namespace WebApplication4.Models
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("DefaultConnection")
        { }
        public virtual DbSet<Product> Products { get; set; }
    }
}
 
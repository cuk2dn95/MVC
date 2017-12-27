using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class DataBaseContext : DbContext
    {
       public DbSet<Student> Students { get; set; }
        public DbSet<Lop> Lops { get; set; }
    }
}
using BlogAlkemy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogAlkemy.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(): base("DefaultConnection")
        {

        }

        public DbSet<Blog> Blog { get; set; }

    }
}
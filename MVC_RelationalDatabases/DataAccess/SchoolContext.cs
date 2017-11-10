using MVC_RelationalDatabases.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_RelationalDatabases.DataAccess
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("DefaultConnection")
        {
        }

        public DbSet<Student> Students { get; set;}
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
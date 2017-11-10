namespace MVC_RelationalDatabases.Migrations
{
    using MVC_RelationalDatabases.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_RelationalDatabases.DataAccess.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_RelationalDatabases.DataAccess.SchoolContext context)
        {

            Teacher teacher = new Teacher { ID=1, Name="Erik Lovbom", Classes = new List<Class>() };

            Class Class = new Class {ID=1, ClassName="5c", Teachers = new List<Teacher>() };
            Class.Teachers.Add(teacher);

            context.Classes.AddOrUpdate(
                c => c.ID,
                Class, new Class {ID = 2, ClassName="6b", Teachers = new List<Teacher>() }

                );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

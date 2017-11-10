using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RelationalDatabases.DataAccess
{
    public class SchoolRepository
    {
        SchoolContext sc = new SchoolContext();

        public IEnumerable<Models.Student> GetAllStudents() //Used to display students
        {
            return sc.Students;
        }

        public IEnumerable<Models.Class> GetAllClasses() //Used to display students
        {
            return sc.Classes;
        }
    }
}
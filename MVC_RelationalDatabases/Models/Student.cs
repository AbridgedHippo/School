using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_RelationalDatabases.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string StudentName { get; set; }
        
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }


    }
}
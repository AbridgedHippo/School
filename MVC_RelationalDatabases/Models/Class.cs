using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_RelationalDatabases.Models
{
    public class Class
    {
        [Key]
        public int ID { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
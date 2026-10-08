using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVC_EntityFramework.Models
{
    public class Employee
    {
        [Key]
        public int Eno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
    }
}
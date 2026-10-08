using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_MVC_EntityFramework.Models
{
    public class EmpContext: DbContext
    {
        public EmpContext() : base("myconn") { }
        public DbSet<Employee> Employees { get; set; }
    }
}
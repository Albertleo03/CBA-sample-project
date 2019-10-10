using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ServiceLayer.DBContext
{
    public class EmloyeeDBcontext:DbContext
    {
        public EmloyeeDBcontext():base("name=EmployeeDBContextconnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
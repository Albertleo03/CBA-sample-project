using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ServiceLayer.DBContext;

namespace ServiceLayer
{
   public interface IService
    {
        IEnumerable<Employee>  Registerdetails(Employee data);
        List<Employee> Getregisterdetails();
        IEnumerable<Employee> UpdateRegisterdetails(int id,Employee data);
    }
}

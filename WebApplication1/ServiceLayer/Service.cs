using ServiceLayer.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer
{
    public class Service : IService
    {

        public List<Employee> Getregisterdetails()
        {
           
            List<Employee> result = new List<Employee>();
            using (var DbContext = new EmloyeeDBcontext())
            {
                result= DbContext.Employees.ToList();
            }
            return result;
        }


        public IEnumerable<Employee> Registerdetails(Employee data)
        {
            IEnumerable<Employee> result = default(IEnumerable<Employee>);
            using (var DbContext = new EmloyeeDBcontext())
            {
                DbContext.Employees.Add(data);
                DbContext.SaveChanges();

                result = DbContext.Employees.AsEnumerable();
            }
            return result;
        }

        public IEnumerable<Employee> UpdateRegisterdetails(int id, Employee data)
        {
            IEnumerable<Employee> result = default(IEnumerable<Employee>);
            using (var DbContext = new EmloyeeDBcontext())
            {
                var dbdata = DbContext.Employees.SingleOrDefault(x => x.id == id);
                dbdata.domainname = data.domainname;
                dbdata.Firstname = data.Firstname;
                dbdata.Lanid = data.Lanid;
                dbdata.Lastname = data.Lastname;
                dbdata.Email = data.Email;
                DbContext.SaveChanges();
                result = DbContext.Employees.AsEnumerable();
            }
            return result;
        }
    }
}

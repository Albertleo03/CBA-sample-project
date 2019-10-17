using System.Collections.Generic;
using System.Web.Http;
using ServiceLayer;
using ServiceLayer.DBContext;
using System.Web.Http.Description;
using System;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/EmployeeRegister")]
    public class EmployeeRegisterController : ApiController
    {
        private readonly IService _service;

        public EmployeeRegisterController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Employee")]
        public List<Employee> GetEmployees()
        {

            var model = _service.Getregisterdetails();
            return model;
        }

        [HttpPost]
        [Route("Employee/add")]
        public IHttpActionResult PostEmloyee(Employee modeldata)
        {
            try
            {
                var model = _service.Registerdetails(modeldata);
                if (model == null)
                {
                    string message = string.Format("Data not Saved.");
                    throw new ArgumentNullException(message);
                }
                return Ok(modeldata);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpPut]
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PutEmloyee(int id, Employee modeldata)
        {
            try
            { 
            var model = _service.UpdateRegisterdetails(id, modeldata);
            if (model == null)
            {
                string message = string.Format("Data not Updated.");
                throw new ArgumentNullException(message);
            }
            return Ok(modeldata);
        }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

    }
}


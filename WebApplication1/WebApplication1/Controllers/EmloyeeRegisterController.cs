using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLayer;
using ServiceLayer.DBContext;
using System.Web.Http.Description;

namespace WebApplication1.Controllers
{
    public class EmloyeeRegisterController : ApiController
    {
            private readonly IService _service;

            public EmloyeeRegisterController(IService service)
            {
                _service = service;
            }

      
            
            public List<Employee> GetEmployees()
            {
            
                var model = _service.Getregisterdetails();
                return model;
                
            }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmloyee(Employee modeldata)
        {

            var model = _service.Registerdetails(modeldata);
            if (model == null)
                return NotFound();
            else
                return CreatedAtRoute("DefaultApi", new { id = modeldata.id }, modeldata);
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult PutEmloyee(int id,Employee modeldata)
        {

            var model = _service.UpdateRegisterdetails(id,modeldata);
            if (model == null)
                return NotFound();
            else
                return CreatedAtRoute("DefaultApi", new { id = modeldata.id }, modeldata);
        }

    }
    }


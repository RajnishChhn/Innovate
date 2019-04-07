using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Innovate.Contracts;
using Innovate.Storage;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Innovate.Web.Api.Controllers
{
    [RoutePrefix("api/v1.0/disaster")]
    public class DisasterController : ApiController
    {
        //Post method to recieve IOT data => call respository to save incident report(time of incident, type of incident, location) in MongoDB

        //Post Method to receive SMS response => call repository to save status in MongoDB

        //get method to get all employee status, parameters=status(safe, unsafe, notResponded, all) => call repository to get emp data as per status
        [HttpGet]
        [Route("employeedetails")]
        public async Task<HttpResponseMessage> Employeedetails(Status status)
        {
            var employeeRepository = new EmployeeRepository();
            var employees = await employeeRepository.GetEmployeeDetailsByStatusAsync(status);

            return Request.CreateResponse(HttpStatusCode.OK, employees);
        }

    }
}
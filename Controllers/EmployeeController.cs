using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("Emp/all")]
        public string GetAllEmployees()
        {
            return "GetAllEmployees() called";
        }

        [Route("Emp/id")]
        public string GetEmployeeById()
        {
            return "GetEmployeeById() called";
        }
    }
}

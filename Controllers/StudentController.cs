using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [Route("[action]/{name:alpha}")]                            //Routing Constraints                      
        public string GetName(string name)
        {
            return $"You are student.\nYour name is {name}.";
        }

        [Route("id/{id:int:min(4)}")]                              //Routing constraints
        public string GetStudentById(int id)
        {
            return $"Student Id: {id.ToString()}";
        }

        //[Route("details/{id:int:max(4)}/{name:alpha:min(2)}")]
        [Route("details")]
        public Dictionary<string, string> GetDetails(int  id, string name)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("id", id.ToString());
            data.Add("name", name);
            return data;
        }
    }
}   

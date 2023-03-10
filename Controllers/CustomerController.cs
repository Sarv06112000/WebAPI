using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutingWebAPI.Models;

namespace RoutingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static List<Customer> custList = new List<Customer>();

        [Route("~/details")]
        [Route("details/{id:int:minlength(1)}/{name:alpha:minlength(2)}/{age:int:minlength(2)}/{location:alpha:minlength(3)}/{department:alpha:minlength(4)}/{salary:double:minlength(5)}")]
        public Customer GetDetails(int id, string name, int age, string location, string department, double salary)
        {
            return new Customer
            {
                Id = id,
                Name = name,
                Age = age,
                Location = location,
                Department = department,
                Salary = salary
            };
        }


        [Route("actionresult")]
        public List<Customer> GetData() 
        {
            /*
            List<Customer> emps = new List<Customer>();
            emps.Add(new Customer() { Id=100, Name="ABC", Age=21, Location="Bandra", Department="Sales", Salary=100000 });
            emps.Add(new Customer() { Id = 101, Name = "DEF", Age = 22, Location = "Delhi", Department = "Clerk", Salary = 10000 });
            emps.Add(new Customer() { Id = 102, Name = "GHI", Age = 23, Location = "Lucknow", Department = "Sales", Salary = 102000 });
            emps.Add(new Customer() { Id = 103, Name = "JKL", Age = 21, Location = "Bengal", Department = "IT", Salary = 105000 });
            emps.Add(new Customer() { Id = 104, Name = "MNO", Age = 24, Location = "Punjab", Department = "Network", Salary = 25000 });
            
            if (emps.Count > 3)
            {
                return Ok(emps);
            }
            else
            {
                return NotFound();
            }
            */
            return custList; 
        }

        //[Route("submitcustomer/{id:int}/{name:alpha}/{age:int}/{location:alpha}/{department:alpha}/{salary:double}")]
        
        [Route("submit")]
        public IActionResult PostData(Customer customer)
        {
            custList.Add(customer);
            return Ok("Data added");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExercise.Models;
namespace WebApiExercise.Controllers
{
    [RoutePrefix("api/emp")]
    public class EmployeeController : ApiController
    {
        //Adding  Static Data for Employee Details
        List<Employee> employee = new List<Employee>()
        {

            new Employee{ empId = 111 , empName = "xyz", role = "Buisness Analyst", age = 50},
            new Employee{ empId = 222 , empName = "abc", role = "People Manager", age = 40},
            new Employee{ empId = 333 , empName = "pqr", role = "Data Scientist", age = 26},
            new Employee{ empId = 444 , empName = "meet", role = "Software developer", age = 21},
            new Employee{ empId = 555 , empName = "ram", role = "Buisness Analyst", age = 30},
            new Employee{ empId = 666 , empName = "aneri", role = "Product Manager", age = 21},
            new Employee{ empId = 777 , empName = "lisa", role = "Intern", age = 34},


        };


        /// Defined GET fucntion to fetch all employees

        [Route("Employee")]
        [HttpGet]
        public List<Employee> FetchAllUsers()
        {
            return employee;
        }
         /// Defined GET fucntion to fetch Employee details based on ID

        [Route("Employee/{id}")]
        // URL : /api/emp/Employee/5
        public Employee Get(int id)
        {
            return employee.Find(x => x.empId == id);
        }

          
        /// Defined GET fucntion to fetch Employee details based on ID
        ///  URL : /api/emp/Employee/5
         [Route("Employee/{id}")]
        public Employee Get(int id)
        {
            return employee.Find(x => x.id == id);
        }
           
        /// Defined GET fucntion to all the  Employee with same job role
        /// URL : /api/emp/Employee/intern
        [Route("Employee/{role}")]
        public Employee Get(string role)
        {
            return employee.Find(x => x.role == role);
        }
          
        /// Defined POST fucntion to a employee
        /// URL : /api/emp/Employee
        [Route("Employee")]
        public List<Employee> Post([FromBody] Employee e)
        {
            employee.Add(e);
            return employee;
        }
          
        /// Defined PUT fucntion to edit Employee detail based on ID
        /// URL : /api/emp/Employee/5
        [Route("Employee/{id}")]
        public List<Employee> Put(int id, [FromBody] Employee e)
        {
            employee = employee.Where(x => x.empId != id).ToList();
            employee.Add(e);
            return employee;
        }

        /// Defined Delete fucntion to delete Employee record  based on ID
        ///  URL : /api/emp/Employee/5
        [Route("Employee/{id}")]
        public List<Employee> Delete(int id)
        {
            employee = employee.Where(x => x.empId != id).ToList();
            return employee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Demo_2.Models
{
    // Step 3 Create a Class and Inherit it from IEmployeeRepository for Dependency Injection
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employee;
        public MockEmployeeRepository()
        {
            _employee = new List<Employee>()
            {
                new Employee {Id = 101, Name = "Ahsan", Email = "ahsansoftengineer@gmail.com", Department = "Dev" },
                new Employee {Id = 102, Name = "Yousuf", Email = "yousuf@gmail.com", Department = "IT" },
                new Employee {Id = 103, Name = "Mobin", Email = "mobin@gmail.com", Department = "HR" },
                new Employee {Id = 104, Name = "asim", Email = "asim@gmail.com", Department = "PayRoll" }
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employee.FirstOrDefault(x => x.Id == Id);
        }
    }
}

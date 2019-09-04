using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Demo_2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_Demo_2.Controllers
{
    public class HomeController : Controller
    {
        // Step 4 Implement Dependency Injection by using private Field and Constructor
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // This where we are returning the Result
        public JsonResult Index()
        {
            return Json(_employeeRepository.GetEmployee(101));
        }
        // After this Implementation we have Error 500
    }
}

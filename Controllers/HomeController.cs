using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Demo_2.Models;
using Core_Demo_2.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_Demo_2.Controllers
{
    [Route("[controller]")]
    [Route("")]
    public class HomeController : Controller
    {
        // Step 4 Implement Dependency Injection by using private Field and Constructor
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // This where we are returning the Result
        [Route("")]
        [Route("Index")]
        [Route("[action]")]
        [Route("Employees")]
        public ViewResult GetEmployees()
        {
            return View(_employeeRepository.GetEmployees());
        }

        [Route("Employee")]
        [Route("Employee/{id?}")]
        [Route("[action]")]
        public ViewResult GetEmployee(int? Id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                PageTitle = "Employee Details",
                Employee = _employeeRepository.GetEmployee(Id ?? 101)
            };
            return View(homeDetailsViewModel);
        }

    }
}

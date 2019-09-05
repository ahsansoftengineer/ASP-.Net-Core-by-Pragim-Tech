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
    public class HomeController : Controller
    {
        // Step 4 Implement Dependency Injection by using private Field and Constructor
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // This where we are returning the Result
        public string Index()
        {
            return _employeeRepository.GetEmployee(101).Name;
        }
        // Changes for Returning the View in MVC Core
        public ViewResult GetEmployee(int Id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                PageTitle = "Employee Details",
                Employee = _employeeRepository.GetEmployee(Id)
            };
            return View(homeDetailsViewModel);
        }
        public ViewResult GetEmployees()
        {
            return View(_employeeRepository.GetEmployees());
        }
    }
}

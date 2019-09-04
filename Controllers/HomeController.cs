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
        public ViewResult Detail()
        {
            return View();
        }
        // Changes for Returning the View in MVC Core
        public ViewResult Details()
        {
            return View(_employeeRepository.GetEmployee(101));
        }
        // Example of View to Custom Display of Random Folder
        public ViewResult PatternView()
        {
            return View("PatternView");
        }
        // Example of View to Custom Display of Abosulte Path
        public ViewResult AbsoluteView()
        { 
            return View("Absolute/AbsoluteView.cshtml");
        }
        // Example of View to Custom Display of Relative Path
        public ViewResult RelativeView()
        {
            return View("../Relative/Relative");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Demo_2.Models
{
    // Step 2 Create an Interface for Dependency Injection
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}

using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;

namespace HelloWeb.Controllers;

public class EmployeeController : Controller
{
    public IActionResult List()
    {
        Employee employee1 = new()
        {
            FirstName = "Ram",
            LastName = "Basnet",
            Designation = "Software Engineer",
            Level = 7,
            Department = "RE9s",
            JoinDate = DateTime.Now
        };

        Employee employee2 = new()
        {
            FirstName = "vidkid",
            LastName = "hehe",
            Designation = "senior Software Engineer",
            Level = 7,
            Department = "JD56",
            JoinDate = DateTime.Now
        };
        List<Employee> employees = new() { employee1, employee2 };

        return View(employees);
    }
}

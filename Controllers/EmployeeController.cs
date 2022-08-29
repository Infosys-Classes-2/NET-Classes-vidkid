using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;
using Microsoft.Data.SqlClient;

namespace HelloWeb.Controllers;

public class EmployeeController : Controller
{

    //employee/list
    
   

        static List<Employee> employees = new()
        {
            new()
        {
            FirstName = "Ram",
            LastName = "Basnet",
            Designation = "Software Engineer",
            Level = 7,
            Department = "RE9s",
            JoinDate = DateTime.Now
        },
            new()
        {
            FirstName = "vidkid",
            LastName = "hehe",
            Designation = "senior Software Developer",
            Level = 7,
            Department = "JD56",
            JoinDate = DateTime.Now
        }
    };
    [HttpGet]
    public IActionResult List()
    {

        return View(employees);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Employee emp)
    {
        // Add to Database
        employees.Add(emp);
        return RedirectToAction(nameof(List));
    }
    public IActionResult Edit(int id)
    {
        var employee = employees.Where(x => x.Id == id).FirstOrDefault();
        return View();
    }
}


    
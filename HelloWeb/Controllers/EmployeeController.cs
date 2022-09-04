using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;
using HelloWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloWeb.Controllers;

public class EmployeeController : Controller
{
    //Tightly Coupled Code
    private readonly EmployeeContext db;

    //Dependency Injecion (DI)
    public EmployeeController(EmployeeContext _db)
    {
        db = _db;
    }


    [HttpGet]
    public async Task<IActionResult> List()
    {

        var employees = await db.Employees.Include(x => x.Department).ToListAsync();
        var employees1 = await db.Employees.Include(x => x.Designation).ToListAsync();

        

        //var queryEmployees = from employee in db.Employees
        //                     join dept in db.Departments on employee.DepartmentId equals dept.Id
        //                     select new
        //                     {
        //                         Name = employee.FirstName,
        //                         Department = dept.Name
        //                     };

        return View(employees);
    }
    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem() 
        { Text = x.Name, Value = x.Id.ToString()
        });


        var designations = await db.Designations.ToListAsync();
        ViewData["Designations"] = designations.Select(x => new SelectListItem()
        {
            Text = x.Name, Value = x.Id.ToString()
        });
        return View();

    }

   

    [HttpPost]
    public async Task<IActionResult> Add(Employee emp)
    {
        //adding to the Employee list
       await db.Employees.AddAsync(emp);
       await db.SaveChangesAsync();

        //submit vaye paxi list ma redirect gareko
        return RedirectToAction(nameof(List)); //"List"
    }
    public async Task<IActionResult> Edit(int id)
    {
        var employee = await db.Employees.FindAsync(id);
        return View(employee);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(Employee emp)
    {
        //Update to the Employee list
        db.Employees.Update(emp);
        await db.SaveChangesAsync();

        //submit vaye paxi list ma redirect gareko
        return RedirectToAction(nameof(List)); //"List"
    }
    public async Task<IActionResult> Delete(int id)
    {
        var employee = await db.Employees.FindAsync(id);
        return View(employee);
    }
    [HttpPost]
    public async Task<IActionResult> Delete(Employee emp)
    {
        //Update to the Employee list
        db.Employees.Remove(emp);
        await db.SaveChangesAsync();

        //submit vaye paxi list ma redirect gareko
        return RedirectToAction(nameof(List)); //"List"
    }


}

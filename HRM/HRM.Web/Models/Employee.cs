﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Web.Models;
public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter Your Firstname")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    public string LastName { get; set; }
   
    public byte Level { get; set; }

    [NotMapped]
    public IFormFile Avatar { get; set; }
    public string? ProfileImage { get; set; }
    public DateTime JoinDate { get; set; }

    //one Employee has only one department, department has multiple employee
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    //One employee has only one designation, single designation can be for multiple employees
    public int DesignationId { get; set; }
    public Designation Designation { get; set; }
}

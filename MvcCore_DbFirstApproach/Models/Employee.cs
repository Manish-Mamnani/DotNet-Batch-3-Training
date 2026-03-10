using System;
using System.Collections.Generic;

namespace MvcCore_DbFirstApproach.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string Name { get; set; } = null!;

    public int? Age { get; set; }

    public int? Salary { get; set; }

    public int? DeptId { get; set; }

    public DateOnly? JoinDate { get; set; }

    public string? City { get; set; }

    public virtual Department? Dept { get; set; }
}

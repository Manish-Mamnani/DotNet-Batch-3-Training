using System;
using System.Collections.Generic;

namespace MvcCore_DbFirstApproach.Models;

public partial class StudentInfo
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? StudentAddress { get; set; }

    public int? Age { get; set; }

    public string? City { get; set; }
}

using System;
using System.Collections.Generic;

namespace MvcCore_DbFirstApproach.Models;

public partial class Product
{
    public int ProdId { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public double? Price { get; set; }

    public string? Description { get; set; }
}

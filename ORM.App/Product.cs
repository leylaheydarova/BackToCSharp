using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? Price { get; set; }

    public virtual Department? Department { get; set; }
}

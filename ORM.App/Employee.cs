using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Employee
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}

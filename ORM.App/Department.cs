using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Department
{
    public int Id { get; set; }

    public string? DName { get; set; }

    public string? DirectorName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

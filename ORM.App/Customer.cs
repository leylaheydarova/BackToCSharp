using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Phonenumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

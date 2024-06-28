using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class OrderStatus
{
    public int Id { get; set; }

    public string? SName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

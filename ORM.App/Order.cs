using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? OrderStatusId { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual OrderStatus? OrderStatus { get; set; }
}

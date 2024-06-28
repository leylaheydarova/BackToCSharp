using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Supplier
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Email { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace ORM.App;

public partial class Person
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Age { get; set; }
}

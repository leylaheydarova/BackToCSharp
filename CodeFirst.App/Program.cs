using CodeFirst.App.context;
using CodeFirst.App.Entities;

var _context = new AppDbContext();
var product = new Product()
{
    Name = "Product A",
    Price = 4.50
};

_context.Produts.Add(product);
_context.SaveChanges();
using Microsoft.EntityFrameworkCore;
using MixPractices.App.Context;
using MixPractices.App.Entities;
using MixPractices.App.Entities.OneToMany;

var _context = new AppDbContext();

//one-to-one
var citizen = new Citizen()
{
    birthdate = DateTime.Now,
    Name = "Test",
    Surname = "test",
    passport = new Passport()
    {
        Finkod = "213je39e3",
        IssuerDate = DateTime.Now,
        ExpireDate = DateTime.Now.AddYears(5),
    }
};
//_context.Citizens.Add(citizen);
//_context.SaveChanges();

List<Passport>passports=_context.Passports.Include(x=>x.Citizen)
    .ToList();
foreach (var passport in passports)
{
    Console.WriteLine($"{passport.Finkod}  {passport.Citizen.Name}");
}

//one-to-many
var category = new ProductCategory()
{
    Name = "Categroy 1"
};
var category2 = new ProductCategory()
{
    Name = "Categroy 2"
};

//_context.ProductCategories.Add(category);
//_context.ProductCategories.Add(category2);
//_context.SaveChanges();

//List<Product> products = new List<Product>()
//{
//    new Product()
//    {
//        Name = "Y.S.L",
//        Price = 21,
//        categoryId=1
//    }
//};

//_context.Products.AddRange(products);
//_context.SaveChanges();

//GetAll() methodu
var products2 = _context.Products.Include(x => x.subcategory).ToList();
foreach (var item in products2)
{
    Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
}

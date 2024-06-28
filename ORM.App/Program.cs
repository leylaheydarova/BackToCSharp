using ORM.App;

var _context = new PracticesContext();
var customer = _context.Customers.ToList();
foreach(var cust in customer)
{
    Console.WriteLine(cust.Id+" "+cust.Name+"     "+cust.Email);
}

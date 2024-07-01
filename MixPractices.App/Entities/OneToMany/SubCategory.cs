using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Entities.OneToMany
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int CategoryId { get; set; } 
        public List<Product> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Entities.OneToMany
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public SubCategory subcategory { get; set; }
        public int subcategoryId { get; set; }
    }
}

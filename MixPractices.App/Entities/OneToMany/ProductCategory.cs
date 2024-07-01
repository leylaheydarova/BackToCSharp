using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Entities.OneToMany
{
    public class ProductCategory
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        //public List<Product> Products { get; set; } // burada one-to-many elaqesi oldugunu entity framework basa dusur, lakin bu adda table column olmayacaq
        public List<SubCategory> SubCategories { get; set; }
    }
}

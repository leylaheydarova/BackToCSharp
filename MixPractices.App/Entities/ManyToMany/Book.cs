using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Entities.ManyToMany
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int pageCount { get; set; }
        public double Price { get; set; }
        public List<Author> AuthorList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Entities
{
    public class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime birthdate { get; set; }
        public Passport passport { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPractices.App.Entities
{
    public class Passport
    {
        public int ID { get; set; }
        public string Finkod { get; set; }
        public DateTime IssuerDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public Citizen Citizen { get; set; }
        public int CitizenId { get; set; }
    }
}

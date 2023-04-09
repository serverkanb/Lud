using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Lud
{
    public class City 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        //public string Area { get; set; }

        //public string Street { get; set; }

        //public string  Apartment { get; set; }

        //public string PostalCode { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }

        public List<District> Districts { get; set; }

    }
}

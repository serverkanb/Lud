using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable 
namespace Lud
{
    public class District
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public string PostalCode { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }

        public List<Street> Streets { get; set; }

    }
}

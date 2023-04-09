using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Lud
{
    public class Region
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SubRegion { get; set; } //curved araştırılacak

        public List<Country> Countries { get; set; }

    }
}

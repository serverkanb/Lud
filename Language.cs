using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Lud
{
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<CountryLanguage> CountryLanguages { get; set; }
    }
}

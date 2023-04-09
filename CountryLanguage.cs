using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Lud
{
    public class CountryLanguage
    {
        public int  CountryId { get; set; }

        public Country Country { get; set; }

        public int  LanguageId { get; set; } 

        public Language Language { get; set; }
    }
}

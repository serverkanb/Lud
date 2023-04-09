#nullable disable
namespace Lud
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NativeName { get; set; }

        public string Alpha2Code { get; set; }

        public string Alpha3Code { get; set; }

        public string CountryPopulation { get; set; }

        public DateTime TimeZones { get; set; }//Hangi  veri tipi kullanılması doğru olur ??

        public string Flag { get; set; } // Link konulacak !!

        public string TopLevelDomain { get; set; }//de,com,uk

        public double Area { get; set; }//Yüzölçümü

        public int CityCount { get; set; }
        public string Currency { get; set; }

        public string CapitalCity { get; set; }

        public string CallingCode { get; set; } //?

        public string NumericCode { get; set; }

        public string Demonym { get; set; }


        #region Relations
        public List<City> Cities { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public List<CountryLanguage> CountryLanguages { get; set; }

        public List<Province> Provinces { get; set; }



        #endregion



    }
}
using CestovnePrikazy.CQR.Queries;

namespace CestovnePrikazy.Services
{
    internal class CityComboBox
    {
        public int Id { get; set; }
        public string CityDetails { get; set; }

        public IList<CityComboBox> GetCities()
        {
            var cityList = new Cities().GetCities();
            var countryList = new Countries().GetCountries();

            var qry = from city in cityList
                      join country in countryList
                      on city.CountryId equals country.Id
                      select new CityComboBox
                      {
                          Id = city.Id,
                          CityDetails = $"{city.Name}, {country.CountryName}"
                      };

            return qry.ToList();
        }
    }
}

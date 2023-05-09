using CestovnePrikazy.CQR.Queries;

namespace CestovnePrikazy.Services
{
    public class ItemsToMainForm
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Surname { get; set; }
        public string StartCityCountry { get; set; }
        public string FinalCityCountry { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string TravelRecordState { get; set; }

        public IEnumerable<ItemsToMainForm> GetItemsToMainForm()
        {
            var travelRecords = new TravelRecords().GetTravelRecords();
            var employees = new Employees().GetEmployees();
            var cities = new Cities().GetCities();
            var countries = new Countries().GetCountries();
            var travelRecordStates = new TravelRecordStates().GetTravelRecordStates();

            var itemsToMainForm = from travelRecord in travelRecords

                                  join employee in employees
                                    on travelRecord.EmployeeId equals employee.Id

                                  join startCity in cities
                                    on travelRecord.TravelStartCity equals startCity.Id
                                  join startCountry in countries
                                    on startCity.CountryId equals startCountry.Id

                                  join finalCity in cities
                                    on travelRecord.TravelFinalCity equals finalCity.Id
                                  join finalCountry in countries
                                    on finalCity.CountryId equals finalCountry.Id

                                  join travelRecordState in travelRecordStates
                                    on travelRecord.TravelRecordState equals travelRecordState.Id

                                  select new ItemsToMainForm
                                  {
                                      Id = travelRecord.Id,
                                      EmployeeId = employee.Id,
                                      EmployeeName = employee.Name,
                                      Surname = employee.Surname,
                                      StartCityCountry = $"{startCity.Name}, {startCountry.CountryName}",
                                      FinalCityCountry = $"{finalCity.Name}, {finalCountry.CountryName}",
                                      StartDateTime = travelRecord.DateTimeStart,
                                      EndDateTime = travelRecord.DateTimeEnd,
                                      TravelRecordState = travelRecordState.StateLevel
                                  };

            return itemsToMainForm;
        }
    }
}

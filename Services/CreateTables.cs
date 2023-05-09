using CestovnePrikazy.CQR.Commands.CreateTables;

namespace CestovnePrikazy.Services
{
    internal class CreateTables
    {
        internal void DoCreateTables()
        {
            var createEmployeeTable = new CreateEmployeeTable();
            createEmployeeTable.BuildTable();
            createEmployeeTable.InsertDemoRecords();

            var createCountryTable = new CreateCountryTable();
            createCountryTable.BuildTable();
            createCountryTable.InsertDemoRecords();

            var createCityTable = new CreateCityTable();
            createCityTable.BuildTable();
            createCityTable.InsertDemoRecords();

            var createMeansOfTransportTable = new CreateMeansOfTransportTable();
            createMeansOfTransportTable.BuildTable();
            createMeansOfTransportTable.InsertDemoRecords();

            var createTravelRecordStateTable = new CreateTravelRecordStateTable();
            createTravelRecordStateTable.BuildTable();
            createTravelRecordStateTable.InsertDemoRecords();

            var createTravelRecordTable = new CreateTravelRecordTable();
            createTravelRecordTable.BuildTable();
        }
    }
}

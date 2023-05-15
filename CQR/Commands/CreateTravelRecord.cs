using CestovnePrikazy.CQR.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CestovnePrikazy.CQR.Commands
{
    internal class CreateTravelRecord
    {
        string connectionString;
        int _employeeId;
        int _startCity;
        int _finalCity;
        DateTime _startDateTime;
        DateTime _endDateTime;
        byte _transport;
        int _stateId;
        GeneralCommand _generalCommand;

        internal CreateTravelRecord(int employeeId, int startCity, int finalCity, DateTime startDateTime, DateTime endDateTime, byte transport, int stateId)
        {
            connectionString = new ConnectionStr().ConnectionString;
            _employeeId = employeeId;
            _startCity = startCity;
            _finalCity = finalCity;
            _startDateTime = startDateTime;
            _endDateTime = endDateTime;
            _transport = transport;
            _stateId = stateId;
            _generalCommand = new GeneralCommand();
        }

        internal void InsertTravelRecord()
        {
            var insertStr = @"INSERT INTO TRAVELRECORDS (EmployeeId, TravelStartCity, TravelFinalCity, DateTimeStart, DateTimeEnd, MeansOfTransport, TravelRecordState)
                              VALUES (@0, @1, @2, @3, @4, @5, @6)";

            var parameters = _generalCommand.ExecutionCommand.Parameters;
            parameters.AddWithValue("@0", _employeeId);
            parameters.AddWithValue("@1", _startCity);
            parameters.AddWithValue("@2", _finalCity);
            parameters.AddWithValue("@3", _startDateTime);
            parameters.AddWithValue("@4", _endDateTime);
            parameters.AddWithValue("@5", _transport);
            parameters.AddWithValue("@6", _stateId);

            _generalCommand.ExecuteTravelRecordCommand(insertStr);
        }
    }
}

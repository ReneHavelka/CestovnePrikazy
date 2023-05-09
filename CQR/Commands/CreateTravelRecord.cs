using CestovnePrikazy.CQR.Common;
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
        }

        internal void InsertTravelRecord()
        {
            var _startDateTimeStr = $"'{_startDateTime.ToString("yyyy-MM-dd HH:mm")}'";
            var _endDateTimeStr = $"'{_endDateTime.ToString("yyyy-MM-dd HH:mm")}'";
            var values = $"{_employeeId}, {_startCity}, {_finalCity}, {_startDateTimeStr}, {_endDateTimeStr}, {_transport}, {_stateId}";
            var insertStr = @"INSERT INTO TRAVELRECORDS (EmployeeId, TravelStartCity, TravelFinalCity, DateTimeStart, DateTimeEnd, MeansOfTransport, TravelRecordState)
                              VALUES (" + values + ")";

            new GeneralCommand().ExecuteTravelRecordCommand(insertStr);
        }
    }
}

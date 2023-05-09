using CestovnePrikazy.CQR.Common;

namespace CestovnePrikazy.CQR.Commands
{
    internal class UpdateTravelRecord
    {
        string connectionString;
        int _iD;
        int _employeeId;
        int _startCity;
        int _finalCity;
        DateTime _startDateTime;
        DateTime _endDateTime;
        byte _transport;
        int _stateId;

        internal UpdateTravelRecord(int iD, int employeeId, int startCity, int finalCity, DateTime startDateTime, DateTime endDateTime, byte transport, int stateId)
        {
            connectionString = new ConnectionStr().ConnectionString;
            _iD = iD;
            _employeeId = employeeId;
            _startCity = startCity;
            _finalCity = finalCity;
            _startDateTime = startDateTime;
            _endDateTime = endDateTime;
            _transport = transport;
            _stateId = stateId;
        }

        internal void DoUpdateTravelRecord()
        {
            var _startDateTimeStr = $"'{_startDateTime.ToString("yyyy-MM-dd HH:mm")}'";
            var _endDateTimeStr = $"'{_endDateTime.ToString("yyyy-MM-dd HH:mm")}'";
            var updateStr = $"UPDATE TRAVELRECORDS SET EmployeeId = {_employeeId}, TravelStartCity = {_startCity}, TravelFinalCity = {_finalCity}, DateTimeStart = {_startDateTimeStr}, "
                          + $"DateTimeEnd = {_endDateTimeStr}, MeansOfTransport = {_transport}, TravelRecordState = {_stateId} WHERE Id = {_iD}";

            new GeneralCommand().ExecuteTravelRecordCommand(updateStr);
        }


    }
}

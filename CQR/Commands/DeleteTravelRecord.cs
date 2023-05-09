using CestovnePrikazy.CQR.Common;

namespace CestovnePrikazy.CQR.Commands
{
    internal class DeleteTravelRecord
    {
        string connectionString;
        int _iD;

        internal DeleteTravelRecord(int iD)
        {
            connectionString = new ConnectionStr().ConnectionString;
            _iD = iD;
        }

        internal void DoDeleteTravelRecord()
        {

            var updateStr = $"DELETE FROM TRAVELRECORDS WHERE Id = {_iD}";

            new GeneralCommand().ExecuteTravelRecordCommand(updateStr);
        }
    }
}

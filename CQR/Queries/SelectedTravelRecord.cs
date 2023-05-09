using CestovnePrikazy.CQR.Common;
using CestovnePrikazy.Models;
using System.Data.SqlClient;

namespace CestovnePrikazy.CQR.Queries
{
    internal class SelectedTravelRecord
    {
        string connectionString;

        internal SelectedTravelRecord()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal TravelRecord GetTravelRecord(int Id)
        {
            IList<TravelRecord> travelRecords = new List<TravelRecord>();
            string queryStr = @"SELECT * FROM TRAVELRECORDS
                                WHERE Id = " + Id;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var travelRecord = new TravelRecord();
                        travelRecord.Id = (int)reader.GetValue(0);
                        travelRecord.DateCreated = DateOnly.FromDateTime((DateTime)reader.GetValue(1));
                        travelRecord.EmployeeId = (int)reader.GetValue(2);
                        travelRecord.TravelStartCity = (int)reader.GetValue(3);
                        travelRecord.TravelFinalCity = (int)reader.GetValue(4);
                        travelRecord.DateTimeStart = (DateTime)reader.GetValue(5);
                        travelRecord.DateTimeEnd = (DateTime)reader.GetValue(6);
                        travelRecord.MeanOfTransport = ((byte[])reader.GetValue(7))[0];
                        travelRecord.TravelRecordState = (int)reader.GetValue(8);
                        travelRecords.Add(travelRecord);
                    }
                }

                sqlCommand.Connection.Close();
            }

            return travelRecords.ToList()[0];
        }



    }
}

using CestovnePrikazy.CQR.Common;
using CestovnePrikazy.Models;
using System.Data.SqlClient;

namespace CestovnePrikazy.CQR.Queries
{
    internal class TravelRecordStates
    {
        string connectionString;

        internal TravelRecordStates()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal IList<TravelRecordState> GetTravelRecordStates()
        {
            IList<TravelRecordState> travelRecordStates = new List<TravelRecordState>();
            string queryStr = @"SELECT * FROM TRAVELRECORDSTATES";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var travelRecordState = new TravelRecordState();
                        travelRecordState.Id = (int)reader.GetValue(0);
                        travelRecordState.StateLevel = (string)reader.GetValue(1);

                        travelRecordStates.Add(travelRecordState);
                    }
                }

                sqlCommand.Connection.Close();
            }

            return travelRecordStates;
        }
    }
}


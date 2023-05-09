using CestovnePrikazy.CQR.Common;
using CestovnePrikazy.Models;
using System.Data.SqlClient;

namespace CestovnePrikazy.CQR.Queries
{
    internal class MeansOfTransports
    {
        string connectionString;

        internal MeansOfTransports()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal IList<MeansOfTransport> GetMeansOfTransport()
        {
            IList<MeansOfTransport> meansOfTransports = new List<MeansOfTransport>();
            string queryStr = @"SELECT * FROM MEANSOFTRANSPORT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var meansOfTransport = new MeansOfTransport();
                        meansOfTransport.Id = (int)reader.GetValue(0);
                        meansOfTransport.MeanOfTransport = (string)reader.GetValue(1);
                        meansOfTransports.Add(meansOfTransport);
                    }
                }

                sqlCommand.Connection.Close();
            }

            return meansOfTransports;
        }
    }
}

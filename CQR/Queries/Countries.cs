using CestovnePrikazy.CQR.Common;
using CestovnePrikazy.Models;
using System.Data.SqlClient;

namespace CestovnePrikazy.CQR.Queries
{
    internal class Countries
    {
        string connectionString;

        internal Countries()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal IList<Country> GetCountries()
        {
            IList<Country> countries = new List<Country>();
            string queryStr = @"SELECT * FROM COUNTRIES";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var country = new Country();
                        country.Id = (int)reader.GetValue(0);
                        country.CountryName = (string)reader.GetValue(1);
                        countries.Add(country);
                    }
                }

                sqlCommand.Connection.Close();
            }

            return countries;
        }
    }
}

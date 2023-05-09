using CestovnePrikazy.CQR.Common;
using CestovnePrikazy.Models;
using System.Data.SqlClient;

namespace CestovnePrikazy.CQR.Queries
{
    internal class Cities
    {
        string connectionString;

        internal Cities()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal IList<City> GetCities()
        {
            IList<City> cities = new List<City>();
            string queryStr = @"SELECT * FROM CITIES";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var city = new City();
                        city.Id = (int)reader.GetValue(0);
                        city.Name = (string)reader.GetValue(1);
                        city.CountryId = (int)reader.GetValue(2);
                        city.Latitude = (float)reader.GetValue(3);
                        city.Longitude = (float)reader.GetValue(4);
                        cities.Add(city);
                    }
                }

                sqlCommand.Connection.Close();
            }

            return cities;
        }


    }
}

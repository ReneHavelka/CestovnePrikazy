using System.Data.SqlClient;
using System.Diagnostics;

namespace CestovnePrikazy.CQR.Common
{
    internal class GeneralCommand
    {
        string connectionString;

        internal GeneralCommand()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal void ExecuteTravelRecordCommand(string sQLStr)
        {
            using (SqlConnection cnn = new(connectionString))
            {
                SqlCommand createTableCommand = new(sQLStr, cnn);

                createTableCommand.Connection.Open();
                createTableCommand.ExecuteNonQuery();
                createTableCommand.Connection.Close();
            }
        }
    }
}

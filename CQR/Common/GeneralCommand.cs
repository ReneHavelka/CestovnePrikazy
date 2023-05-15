using System.Data.SqlClient;
using System.Diagnostics;

namespace CestovnePrikazy.CQR.Common
{
    internal class GeneralCommand
    {
        string connectionString;
        internal SqlCommand ExecutionCommand { get; set; }

        internal GeneralCommand()
        {
            connectionString = new ConnectionStr().ConnectionString;
            ExecutionCommand = new SqlCommand();
        }

        internal void ExecuteTravelRecordCommand(string sQLStr)
        {
            using (SqlConnection cnn = new(connectionString))
            {
                ExecutionCommand.Connection = cnn;
                ExecutionCommand.CommandText = sQLStr;
                ExecutionCommand.Connection.Open();
                ExecutionCommand.ExecuteNonQuery();
                ExecutionCommand.Connection.Close();
            }
        }
    }
}

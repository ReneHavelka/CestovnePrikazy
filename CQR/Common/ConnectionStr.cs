using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CestovnePrikazy.CQR.Common
{
    internal class ConnectionStr
    {
        internal string ConnectionString { get; }

        internal ConnectionStr(string dtBase = @"C:\Users\RH\source\repos\CestovnePrikazy\TravelExpenses.mdf")
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;";
            ConnectionString += "AttachDbFilename=" + dtBase;
        }
    }
}

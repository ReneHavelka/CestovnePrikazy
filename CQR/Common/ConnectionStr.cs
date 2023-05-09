namespace CestovnePrikazy.CQR.Common
{
    internal class ConnectionStr
    {
        internal string ConnectionString { get; }

        internal ConnectionStr()
        {
            ConnectionString =
              @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RH\source\repos\CestovnePrikazy\TravelExpenses.mdf;
              Integrated Security=True";
        }
    }
}

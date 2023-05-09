namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateMeansOfTransportTable
    {
        string createTableStr;
        CreateTable createTable;

        internal CreateMeansOfTransportTable()
        {
            createTableStr = @"CREATE TABLE MEANSOFTRANSPORT
            (
              Id Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
              MeanOfTransport VarChar(15)
            )";

            createTable = new CreateTable();
        }

        internal void BuildTable()
        {
            createTable.BuildTable(createTableStr);
        }

        internal void InsertDemoRecords()
        {
            var insertStr = @"INSERT INTO MEANSOFTRANSPORT (MeanOfTransport)
                              VALUES
                              ('Služobné auto'),
                              ('Autobus'),
                              ('MHD'),
                              ('Pešo'),
                              ('Vlak'),
                              ('Taxi'),
                              ('Lietadlo')";

            createTable.BuildTable(insertStr);
        }
    }
}

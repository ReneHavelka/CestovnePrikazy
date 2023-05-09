namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateTravelRecordStateTable
    {
        string createTableStr;
        CreateTable createTable;
        internal CreateTravelRecordStateTable()
        {
            createTableStr = @"CREATE TABLE TRAVELRECORDSTATES
            (
              Id Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
              StateLevel VarChar(10)
            )";

            createTable = new CreateTable();
        }

        internal void BuildTable()
        {
            createTable.BuildTable(createTableStr);
        }

        internal void InsertDemoRecords()
        {
            var insertStr = @"INSERT INTO TRAVELRECORDSTATES (StateLevel)
                              VALUES
                              ('Vytvorený'),
                              ('Schválený'),
                              ('Vyúčtovaný'),
                              ('Zrušený')";

            createTable.BuildTable(insertStr);
        }
    }
}

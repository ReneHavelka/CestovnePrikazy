namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateCountryTable
    {
        string createTableStr;
        CreateTable createTable;

        internal CreateCountryTable()
        {
            createTableStr = @"CREATE TABLE COUNTRIES
              (
              Id Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
              CountryName VarChar(30)
              )";

            createTable = new CreateTable();
        }

        internal void BuildTable()
        {
            createTable.BuildTable(createTableStr);
        }

        internal void InsertDemoRecords()
        {
            var insertStr = @"INSERT INTO COUNTRIES (CountryName)
                              VALUES
                              ('Slovensko'),
                              ('Česká republika'),
                              ('Rakúsko')";

            createTable.BuildTable(insertStr);
        }
    }
}

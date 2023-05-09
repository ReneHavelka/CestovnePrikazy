namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateCityTable
    {
        string createTableStr;
        CreateTable createTable;

        internal CreateCityTable()
        {
            createTableStr = @"CREATE TABLE CITIES
            (
              Id Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
              Name VarChar(30),
              CountryId int FOREIGN KEY REFERENCES COUNTRIES(Id),
              Latitude Real,                     
              Longitude Real
            )";

            createTable = new CreateTable();
        }

        internal void BuildTable()
        {
            createTable.BuildTable(createTableStr);
        }

        internal void InsertDemoRecords()
        {
            var insertStr = @"INSERT INTO CITIES (Name, CountryId, Latitude, Longitude)
                              VALUES
                              ('Bratislava', 1, 46.6690, 196990),
                              ('Praha', 2, 50.0755, 14.4378),
                              ('Viedeň', 3, 48.2082, 16.3738)";

            createTable.BuildTable(insertStr);
        }
    }
}

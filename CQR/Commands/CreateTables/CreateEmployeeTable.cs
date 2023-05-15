namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateEmployeeTable
    {
        string createTableStr;
        CreateTable createTable;

        internal CreateEmployeeTable()
        {
            createTableStr = @"CREATE TABLE EMPLOYEES
            (
              Id Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
              EmployeeNo VarChar(10) NOT NULL UNIQUE,
              Name VarChar(30),
              Surname VarChar(30),
              DateOfBirth Date,
              PersonalIdNo BigInt
            )";

            createTable = new CreateTable();
        }

        internal void BuildTable()
        {
            createTable.BuildTable(createTableStr);
        }

        internal void InsertDemoRecords()
        {
            var insertStr = @"INSERT INTO EMPLOYEES (EmployeeNo, Name, Surname, DateOfBirth, PersonalIdNo)
                              VALUES
                              ('A000000123', 'Ján', 'Pracovitý', '19900102', 199001021234),
                              ('B000000345', 'Peter', 'Snaživý', '20010203', 200102034567),
                              ('C000000678', 'Ondrej', 'Usilovný', '20020304', 200203048901)";

            createTable.BuildTable(insertStr);
        }
    }
}

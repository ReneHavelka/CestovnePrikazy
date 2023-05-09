namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateTravelRecordTable
    {
        string createTableStr;
        CreateTable createTable;

        internal CreateTravelRecordTable()
        {
            createTableStr = @"CREATE TABLE TRAVELRECORDS
            (
              Id Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
              DateCreated Date NOT NULL DEFAULT GETDATE(),
              EmployeeId Int FOREIGN KEY REFERENCES EMPLOYEES(Id),
              TravelStartCity Int FOREIGN KEY REFERENCES CITIES(Id),
              TravelFinalCity Int FOREIGN KEY REFERENCES CITIES(Id),
              DateTimeStart DateTime,
              DateTimeEnd DateTime,
              MeansOfTransport Binary(1),
              TravelRecordState Int FOREIGN KEY REFERENCES TRAVELRECORDSTATES(Id)
            )";

            createTable = new CreateTable();
        }

        internal void BuildTable()
        {
            createTable.BuildTable(createTableStr);
        }
    }
}

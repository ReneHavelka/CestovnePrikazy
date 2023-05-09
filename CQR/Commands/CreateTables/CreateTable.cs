using CestovnePrikazy.CQR.Common;

namespace CestovnePrikazy.CQR.Commands.CreateTables
{
    internal class CreateTable
    {
        GeneralCommand generalCommand;
        internal CreateTable()
        {
            generalCommand = new GeneralCommand();
        }

        internal void BuildTable(string createTableStr)
        {
            generalCommand.ExecuteTravelRecordCommand(createTableStr);
        }
    }
}

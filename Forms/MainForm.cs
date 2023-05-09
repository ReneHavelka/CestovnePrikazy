using CestovnePrikazy.Forms;
using CestovnePrikazy.Services;

namespace CestovnePrikazy
{
    public partial class MainForm : Form
    {
        internal static int EmployeeId { get; set; } = -1;
        IList<ItemsToMainForm> itemList;

        public MainForm()
        {
            InitializeComponent();
            itemList = new ItemsToMainForm().GetItemsToMainForm().ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Prejde cez filter. PÙvodnÈ nastavenie EmployeeId = -1 znamen·, ûe z·znamy nie s˙ filtrovanÈ.
            FilteredItems();
        }

        private void FilteredItems()
        {
            IList<ItemsToMainForm> itemListFiltered;

            //Vöetky z·znamy
            if (EmployeeId == -1)
            {
                itemListFiltered = itemList;
            }
            //Filter aktu·lny, bezozmeny
            else if (EmployeeId == 0)
            {
                return;
            }
            else
            //Nov˝ filter
            {
                itemListFiltered = itemList.Where(x => x.EmployeeId == EmployeeId).ToList();
            }
            itemTable.DataSource = itemListFiltered;
        }

        private void createTables_Click(object sender, EventArgs e)
        {
            //DoËasne - vytvorenie tabuliek datab·zy - CQR\CreateTables
            new CreateTables().DoCreateTables();
        }

        private void itemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit·cia z·namu alebo vymazanie
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var columnName = itemTable.Columns[e.ColumnIndex].Name;
                var id = (int)itemTable.Rows[e.RowIndex].Cells["id"].Value;

                switch (columnName)
                {
                    //Edit·cia
                    case "editBtn":
                        this.Hide();
                        var editTravelOrderForm = new EditTravelOrder(id);
                        editTravelOrderForm.ShowDialog();
                        ResetDataSource();
                        this.Visible = true;
                        break;
                    //Vymazanie
                    case "deleteBtn":
                        this.Hide();
                        var deleteTravelOrderForm = new DeleteTravelOrder(id);
                        deleteTravelOrderForm.ShowDialog();
                        ResetDataSource();
                        this.Visible = true;
                        break;
                }
            }


        }

        //Nov˝ z·znam
        private void newRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createTravelOrderForm = new CreateTravelOrder();
            createTravelOrderForm.ShowDialog();
            ResetDataSource();
            this.Visible = true;
        }

        //Filtr·cia podæa ˙ËastnÌka prac. cesty
        private void filter_Click(object sender, EventArgs e)
        {
            var employeeFilter = new EmployeeFilter();
            employeeFilter.ShowDialog();
            FilteredItems();
        }

        //Aktualiz·cia po pridanÌ z·znamu alebo edit·cii
        private void ResetDataSource()
        {
            itemList = new ItemsToMainForm().GetItemsToMainForm().ToList();
            //MusÌ akceptovaù pÙvodnÈ fitrovanie aj po zmen·ch - edit·cia, vymazanie.s
            FilteredItems();
        }
    }
}
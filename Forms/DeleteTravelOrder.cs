using CestovnePrikazy.CQR.Commands;
using CestovnePrikazy.CQR.Queries;
using CestovnePrikazy.Models;
using CestovnePrikazy.Services;

namespace CestovnePrikazy.Forms
{
    public partial class DeleteTravelOrder : Form
    {
        TravelRecord travelRecord;
        int _iD;

        public DeleteTravelOrder(int iD)
        {
            InitializeComponent();
            travelRecord = new SelectedTravelRecord().GetTravelRecord(iD);
            _iD = iD;
        }

        private void DeleteTravelOrder_Load(object sender, EventArgs e)
        {
            //Nastavenia
            comboBoxEmployee.DataSource = new EmployeeComboBox().GetEmployees();
            comboBoxEmployee.DisplayMember = "EmployeeDetails";
            comboBoxEmployee.ValueMember = "Id";
            comboBoxEmployee.SelectedValue = travelRecord.EmployeeId;

            comboBoxStartCity.DataSource = new CityComboBox().GetCities();
            comboBoxStartCity.DisplayMember = "CityDetails";
            comboBoxStartCity.ValueMember = "Id";
            comboBoxStartCity.SelectedValue = travelRecord.TravelStartCity;

            comboBoxFinalCity.DataSource = new CityComboBox().GetCities();
            comboBoxFinalCity.DisplayMember = "CityDetails";
            comboBoxFinalCity.ValueMember = "Id";
            comboBoxFinalCity.SelectedValue = travelRecord.TravelFinalCity;

            dateTimePickerStart.CustomFormat = " dd.MM.yyyy, HH:mm";
            dateTimePickerStart.Value = travelRecord.DateTimeStart;

            dateTimePickerEnd.CustomFormat = " dd.MM.yyyy, HH:mm";
            dateTimePickerEnd.Value = travelRecord.DateTimeEnd;

            comboBoxState.DataSource = new TravelRecordStates().GetTravelRecordStates();
            comboBoxState.DisplayMember = "StateLevel";
            comboBoxState.ValueMember = "Id";
            comboBoxState.SelectedValue = travelRecord.TravelRecordState;

            //Nastavenie true/false pre konkrétne druhy dopravy
            var meanOfTransport = travelRecord.MeanOfTransport;

            var checkedListBoxTransportCount = checkedListBoxTransport.Items.Count;

            for (int i = 0; i < checkedListBoxTransportCount; i++)
            {
                checkedListBoxTransport.SetItemChecked(i, 1 == ((meanOfTransport >> i) & 1));
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //Vymazanie záznamu
            new DeleteTravelRecord(_iD).DoDeleteTravelRecord();
            this.Close();
        }
    }
}

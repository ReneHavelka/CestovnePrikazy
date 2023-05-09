using CestovnePrikazy.CQR.Commands;
using CestovnePrikazy.CQR.Queries;
using CestovnePrikazy.Models;
using CestovnePrikazy.Services;
using CestovnePrikazy.Validators;

namespace CestovnePrikazy.Forms
{
    public partial class EditTravelOrder : Form
    {
        TravelRecord travelRecord;
        int _iD;
        int employeeId;
        int startCity;
        int finalCity;
        DateTime startDateTime;
        DateTime endDateTime;
        int transport = 0;
        int stateId;

        public EditTravelOrder(int iD)
        {
            InitializeComponent();
            //Parameter zo zoznamu - MainForm, ktorý slúži ako index.
            _iD = iD;
            travelRecord = new SelectedTravelRecord().GetTravelRecord(iD);
        }

        private void EditTravelOrder_Load(object sender, EventArgs e)
        {
            //Nastavenia Control-prvkov
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

            
            var meanOfTransport = travelRecord.MeanOfTransport;

            //Vkladá do CheckedListBox pre konkrétne druhy dopravy hodnoty true/false z bitov jedného byte - MeanOfTransport.
            var checkedListBoxTransportCount = checkedListBoxTransport.Items.Count;

            for (int i = 0; i < checkedListBoxTransportCount; i++)
            {
                checkedListBoxTransport.SetItemChecked(i, 1 == ((meanOfTransport >> i) & 1));
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeId = (int)comboBoxEmployee.SelectedValue;
        }

        private void comboBoxStartCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            startCity = (int)comboBoxStartCity.SelectedValue;
        }

        private void comboBoxFinalCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            finalCity = (int)comboBoxFinalCity.SelectedValue;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            startDateTime = (DateTime)dateTimePickerStart.Value;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            endDateTime = (DateTime)dateTimePickerEnd.Value;
        }

        private void checkedListBoxTransport_Leave(object sender, EventArgs e)
        {
            var checkedItemsIdxs = checkedListBoxTransport.CheckedIndices;
            transport = 0;

            foreach (var checkedItem in checkedItemsIdxs)
            {
                var indxs = (int)checkedItem;
                transport += 1 << indxs;
            }
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            stateId = (int)comboBoxState.SelectedValue;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //Validácia pred uložením do databázy.
            var validatorEndDateTime = new EndDateTimeValidator(startDateTime, endDateTime);
            try
            {
                validatorEndDateTime.EndDateTimeValidate();
            }
            catch
            {
                ex_EndDateTimeMsg.Visible = true;
                return;
            }

            //Uloženie do databázy
            var updateTravelOrder = new UpdateTravelRecord(_iD, employeeId, startCity, finalCity, startDateTime, endDateTime, (byte)transport, stateId);
            updateTravelOrder.DoUpdateTravelRecord();
            this.Close();
        }
    }
}

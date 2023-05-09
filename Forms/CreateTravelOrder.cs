using CestovnePrikazy.CQR.Commands;
using CestovnePrikazy.CQR.Queries;
using CestovnePrikazy.Services;
using CestovnePrikazy.Validators;
using System.Diagnostics;

namespace CestovnePrikazy.Forms
{
    public partial class CreateTravelOrder : Form
    {
        int employeeId;
        int startCity;
        int finalCity;
        DateTime startDateTime;
        DateTime endDateTime;
        int transport = 0;
        int stateId;



        public CreateTravelOrder()
        {
            InitializeComponent();
        }

        private void CreateTravelOrder_Load(object sender, EventArgs e)
        {
            //Nastavenia Control-prvkov
            var employeeComboBoxList = new EmployeeComboBox().GetEmployees();
            EmployeeComboBox employeeComboBox = new();
            employeeComboBox.Id = 0;
            employeeComboBox.EmployeeDetails = "- Vyber zamestnanca -";
            employeeComboBoxList.Insert(0, employeeComboBox);
            comboBoxEmployee.DataSource = employeeComboBoxList;
            comboBoxEmployee.DisplayMember = "EmployeeDetails";
            comboBoxEmployee.ValueMember = "Id";

            var startCityComboBoxList = new CityComboBox().GetCities();
            CityComboBox cityComboBox = new();
            cityComboBox.Id = 0;
            cityComboBox.CityDetails = "- Vyber mesto -";
            startCityComboBoxList.Insert(0, cityComboBox);
            comboBoxStartCity.DataSource = startCityComboBoxList;
            comboBoxStartCity.DisplayMember = "CityDetails";
            comboBoxStartCity.ValueMember = "Id";

            var finalCityComboBoxList = new CityComboBox().GetCities();
            finalCityComboBoxList.Insert(0, cityComboBox);
            comboBoxFinalCity.DataSource = finalCityComboBoxList;
            comboBoxFinalCity.DisplayMember = "CityDetails";
            comboBoxFinalCity.ValueMember = "Id";

            dateTimePickerStart.CustomFormat = " dd.MM.yyyy, HH:mm";
            dateTimePickerStart.Value = DateTime.Now;

            dateTimePickerEnd.CustomFormat = " dd.MM.yyyy, HH:mm";
            dateTimePickerEnd.Value = DateTime.Now;

            comboBoxState.DataSource = new TravelRecordStates().GetTravelRecordStates();
            comboBoxState.DisplayMember = "StateLevel";
            comboBoxState.ValueMember = "Id";
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
            //V jednom byte-e (8 bitov) sú hodnoty bool pre sedem druhov dopravy (0 - false, 1 - true).
            var checkedItemsIdxs = checkedListBoxTransport.CheckedIndices;
            transport = 0;

            //Zisťuje 0 alebo 1, t.j. false alebo true a vkladá do premennej int. Táto je potom konvertovaná na byte.
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
            var validatorEmployee = new SelectionValidator(employeeId);
            try
            {
                validatorEmployee.SelectionValidate();
            }
            catch
            {
                ex_messageEmployee.Visible = true;
                return;
            }

            var validatorStartCity = new SelectionValidator(startCity);
            try
            {
                 validatorStartCity.SelectionValidate();
            }
            catch
            {
                ex_startCityMsg.Visible = true;
                return;
            }

            var validatorFinalCity = new SelectionValidator(finalCity);
            try
            {
                validatorFinalCity.SelectionValidate();
            }
            catch
            {
                ex_finalCityMsg.Visible = true;
                return;
            }

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
            var createTravelOrder = new CreateTravelRecord(employeeId, startCity, finalCity, startDateTime, endDateTime, (byte)transport, stateId);
            createTravelOrder.InsertTravelRecord();
            this.Close();
        }
    }
}

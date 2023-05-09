using CestovnePrikazy.Services;

namespace CestovnePrikazy.Forms
{
    public partial class EmployeeFilter : Form
    {
        public EmployeeFilter()
        {
            InitializeComponent();
        }

        //Filter záznamov v zozname - MainForm
        private void EmployeeFilter_Load(object sender, EventArgs e)
        {
            var getEmployees = new EmployeeComboBox().GetEmployees();
            EmployeeComboBox employeeComboBox = new EmployeeComboBox();
            employeeComboBox.Id = -1;
            employeeComboBox.EmployeeDetails = "Zruš filter";
            getEmployees.Add(employeeComboBox);
            comboBoxEmployee.DataSource = getEmployees;
            comboBoxEmployee.DisplayMember = "EmployeeDetails";
            comboBoxEmployee.ValueMember = "Id";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            MainForm.EmployeeId = (int)comboBoxEmployee.SelectedValue;
            this.Close();
        }
    }
}

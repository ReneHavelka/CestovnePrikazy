using CestovnePrikazy.CQR.Queries;

namespace CestovnePrikazy.Services
{
    internal class EmployeeComboBox
    {
        public int Id { get; set; }
        public string EmployeeDetails { get; set; }

        public IList<EmployeeComboBox> GetEmployees()
        {
            var employeeList = new Employees().GetEmployees();

            var qry = from employee in employeeList
                      select new EmployeeComboBox
                      {
                          Id = employee.Id,
                          EmployeeDetails = $"{employee.Name} {employee.Surname}, osobné č.: {employee.EmployeeNo}"
                      };

            return qry.ToList();
        }
    }
}

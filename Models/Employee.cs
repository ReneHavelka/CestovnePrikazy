namespace CestovnePrikazy.Models
{
    public record class Employee
    {
        public virtual int Id { get; set; }
        public virtual string EmployeeNo { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual DateOnly DateOfBirth { get; set; }
    }
}

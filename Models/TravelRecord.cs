namespace CestovnePrikazy.Models
{
    public class TravelRecord
    {
        public virtual int Id { get; set; }
        public virtual DateOnly DateCreated { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public virtual int EmployeeId { get; set; }
        public virtual int TravelStartCity { get; set; }
        public virtual int TravelFinalCity { get; set; }
        public virtual DateTime DateTimeStart { get; set; }
        public virtual DateTime DateTimeEnd { get; set; }
        //V jednom byte-e je hodnota bool pre sedem druhov dopravy (0 - false, 1 - true).
        public virtual byte MeanOfTransport { get; set; }
        public virtual int TravelRecordState { get; set; }
    }
}

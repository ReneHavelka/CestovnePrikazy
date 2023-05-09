namespace CestovnePrikazy.Models
{
    public record class Country
    {
        public virtual int Id { get; set; }
        public virtual string CountryName { get; set; }
    }
}

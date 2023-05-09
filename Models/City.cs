namespace CestovnePrikazy.Models
{
    public class City
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int CountryId { get; set; }
        public virtual float Latitude { get; set; }
        public virtual float Longitude { get; set; }
    }
}

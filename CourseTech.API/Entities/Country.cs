namespace CourseTech.API.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetail> CountryDetails { get; set; }
    }
}

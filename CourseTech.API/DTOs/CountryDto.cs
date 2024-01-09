namespace CourseTech.API.DTOs
{
    public class CountryDto
    {
        public string Number { get; set; }
        public string CountryCode { get; set; }    
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailDto> CountryDetails { get; set; }
    }
}

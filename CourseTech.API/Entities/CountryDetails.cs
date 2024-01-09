using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseTech.API.Entities
{
    public class CountryDetail
    {
        [Key]
        public int CountryDetailId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}

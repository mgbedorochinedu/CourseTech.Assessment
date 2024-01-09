using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseTech.API.Entities
{
    public class PhoneNumberInfo
    {
        [Key]
        public int PhoneNumberInfoId { get; set; }
        public string Number { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}

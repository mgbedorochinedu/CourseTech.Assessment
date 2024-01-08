using System.ComponentModel.DataAnnotations.Schema;

namespace CourseTech.API.Entities
{
    public class PhoneNumberInfo
    {
        public int PhoneNumberInfoId { get; set; }
        public string Number { get; set; }
        [ForeignKey("Country")]
        public Country Country { get; set; }
    }
}

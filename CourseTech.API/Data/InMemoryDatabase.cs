using CourseTech.API.Entities;

namespace CourseTech.API.Data
{
    public static class InMemoryDatabase
    {
        public static List<Country> Countries { get; set; } = new List<Country>
        {
            new Country { CountryId = 1, CountryCode = "234", Name = "Nigeria", CountryIso = "NG" },
            new Country { CountryId = 2, CountryCode = "233", Name = "Ghana", CountryIso = "GH" },
            new Country { CountryId = 3, CountryCode = "229", Name = "Benin Republic", CountryIso = "BN" },
            new Country { CountryId = 4, CountryCode = "225", Name = "Côte d'Ivoire", CountryIso = "CIV" }
        };
       

        public static List<CountryDetail> CountryDetails { get; set; } = new List<CountryDetail>
        {
             new CountryDetail { CountryDetailId = 1, CountryId = 1, Operator = "MTN Nigeria", OperatorCode = "MTN NG" },
             new CountryDetail { CountryDetailId = 2, CountryId = 1, Operator = "Airtel Nigeria", OperatorCode = "ANG" },
             new CountryDetail { CountryDetailId = 3, CountryId = 1, Operator = "9 Mobile Nigeria", OperatorCode = "ETN" },
             new CountryDetail { CountryDetailId = 4, CountryId = 1, Operator = "Globacom Nigeria", OperatorCode = "GLO NG" },
             new CountryDetail { CountryDetailId = 5, CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH" },
             new CountryDetail { CountryDetailId = 6, CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana" },
             new CountryDetail { CountryDetailId = 7, CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana" },
             new CountryDetail { CountryDetailId = 8, CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin" },
             new CountryDetail { CountryDetailId = 9, CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin" },
             new CountryDetail { CountryDetailId = 10, CountryId = 4, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV" },
        };
    }
}

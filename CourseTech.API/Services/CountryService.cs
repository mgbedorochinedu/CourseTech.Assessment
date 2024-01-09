using CourseTech.API.Data;
using CourseTech.API.DTOs;
using CourseTech.API.IService;
using CourseTech.API.ServiceResponse;

namespace CourseTech.API.Services
{
    public class CountryService : ICountryService
    {
        public CountryService()
        {

        }


        public async Task<BaseResponse> GetCountryDetails(string phoneNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(phoneNumber))
                    return new BaseResponse(false, null, "Phone nunber cannot be empty.");

                string countryCode = phoneNumber.Substring(0, 3);

                var country = InMemoryDatabase.Countries.FirstOrDefault(c => c.CountryCode.ToString() == countryCode);
                if (country == null)
                    return new BaseResponse(false, null, "Country not found.");

                
                var result = new 
                {
                    number = phoneNumber,
                    countryCode = country.CountryCode,
                    country = country.Name,
                    countryIso = country.CountryIso,                  
                    CountryDetails = InMemoryDatabase.CountryDetails.Where(x => x.CountryId == country.CountryId).Select(cd => new CountryDetailDto
                    {
                        Operator = cd.Operator,
                        OperatorCode = cd.OperatorCode
                    }).ToList()
                };
                return new BaseResponse(true, result, "Fetched data successful");

            }
            catch (Exception ex)
            {
                return new BaseResponse(false, null, $"An error occur: {ex.Message}"); //Log should handle this
            }
        }






    }
}

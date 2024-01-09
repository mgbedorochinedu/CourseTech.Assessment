using CourseTech.API.ServiceResponse;

namespace CourseTech.API.IService
{
    public interface ICountryService
    {
        Task<BaseResponse> GetCountryDetails(string phoneNumber);
    }
}

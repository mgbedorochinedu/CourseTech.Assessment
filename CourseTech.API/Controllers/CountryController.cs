using CourseTech.API.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseTech.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryDetails([FromQuery] string phoneNumber)
        {
            var response = await _countryService.GetCountryDetails(phoneNumber);
            return Ok(response);
        }
    }
}
